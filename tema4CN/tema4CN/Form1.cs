using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tema4CN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double fx(double x, double y) => (7 * Math.Pow(x, 3) - y + 1) / 10;

        public double fy(double x, double y) => (8 * Math.Pow(y, 3) + x - 1) / 11;

        public double f1(double x, double y) => 7*Math.Pow(x, 3) - 10*x - y + 1;

        public double f2(double x, double y) => 8*Math.Pow(y, 3) - 11*y + x - 1;

        public double df1dx(double x, double y) => 21*x*x - 10;

        public double df1dy(double x, double y) => -1;

        public double df2dx(double x, double y) => 1;

        public double df2dy(double x, double y) => 24*y*y - 11;

        public double epsilon = 1.0e-10;

        private void ClearGrid()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.RowHeadersWidth = 30;
        }

        private void concractiei_click(object sender, EventArgs e)
        {
            ClearGrid();
            double x0 = 0;
            double y0 = 0;
            dataGridView1.Columns.Add("X", "X");
            dataGridView1.Columns.Add("Y", "Y");
            dataGridView1.Columns.Add("Rez1", "Rez 1");
            dataGridView1.Columns.Add("Rez2", "Rex 2");
            double norma = 1.0;
            do
            {
                double x1 = fx(x0, y0);
                double y1 = fy(x0, y0);
                norma = Math.Max(Math.Abs(x1 - x0), Math.Abs(y1 - y0));
                x0 = x1;
                y0 = y1;
            } while (norma>epsilon);
            double rez1 = f1(x0, y0);
            double rez2 = f2(x0, y0);
            dataGridView1.Rows.Add(x0, y0, rez1, rez2);

            //Contractiei
        }

        private void gaussSiedel_Click(object sender, EventArgs e)
        {
            ClearGrid();
            double x0 = 0;
            double y0 = 0;
            dataGridView1.Columns.Add("X", "X");
            dataGridView1.Columns.Add("Y", "Y");
            dataGridView1.Columns.Add("Rez1", "Rez 1");
            dataGridView1.Columns.Add("Rez2", "Rex 2");
            double norma = 1.0;
            do
            {
                double x1 = fx(x0, y0);
                double y1 = fy(x0, y0);
                norma = Math.Max(Math.Abs(x1 - x0), Math.Abs(y1 - y0));
                x0 = x1;
                y0 = y1;

            } while (norma>epsilon);
            double rez1 = f1(x0, y0);
            double rez2 = f2(x0, y0);
            dataGridView1.Rows.Add(x0, y0, rez1, rez2);

        }

        private void newton_Click(object sender, EventArgs e)
        {
            ClearGrid();
            double a = 2;
            double h = 0.5;
            double k = 2*a/h;
            int p = 0;
            int limit = 100000;
            dataGridView1.Columns.Add("X", "Sol X");
            dataGridView1.Columns.Add("Y", "Sol Y");
            List<double> solX=new List<double>();
            List<double> solY = new List<double>();
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    double x0 = -a + i*h;
                    double y0 = -a + j*h;
                    int n = 0;
                    double max = 1;

                    do
                    {
                        double dfx = df1dx(x0, y0);
                        double dfy = df1dx(x0, y0);
                        double dgx = df2dx(x0, y0);
                        double dgy = df2dy(x0, y0);
                        double d = (dfx * dgy) - (dfy * dgx);
                        double x1 = x0 - (dgy * f1(x0, y0) - dfy * f2(x0, y0)) / d;
                        double y1 = y0 - (-dgx * f1(x0, y0) + dfx * f2(x0, y0)) / d;
                        max = Math.Max(Math.Abs(x1 - x0), Math.Abs(y1 - y0));
                        n++;
                        x0 = x1;
                        y0 = y1;
                    } while (n<=limit && max>epsilon);
                    if (solX.Count==0)
                    {
                        solX.Add(x0);
                        solY.Add(y0);
                    }
                    bool ok = true;
                    for (int l = 0; l < solX.Count; l++)
                        {
                            if (Math.Abs(solX[l] - x0) < 1e-5 && Math.Abs(solY[l] - y0) < 1e-5)
                            {
                                ok = false;
                            }
                        }
                    if (ok == true)
                    {
                        solX.Add(x0);
                        solY.Add(y0);
                    }
                }
            }
            for (int i = 0; i < solX.Count; i++)
            {
                dataGridView1.Rows.Add(solX[i], solY[i]);
            }
            
        }

        private void newtonSimp_Click(object sender, EventArgs e)
        {
            ClearGrid();
            double a = 2;
            double h = 0.5;
            double k = 2 * a / h;
            double c1 = 2;
            double c2 = 1;
            int p = 0;
            int limit = 100000;
            dataGridView1.Columns.Add("X", "Sol X");
            dataGridView1.Columns.Add("Y", "Sol Y");
            List<double> solX = new List<double>();
            List<double> solY = new List<double>();
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    double x0 = -a + i * h;
                    double y0 = -a + j * h;
                    int n = 0;
                    double max = 1;

                    do
                    {
                        double dfx = df1dx(c1, c2);
                        double dfy = df1dx(c1, c2);
                        double dgx = df2dx(c1, c2);
                        double dgy = df2dy(c1, c2);
                        double d = (dfx * dgy) - (dfy * dgx);
                        double x1 = x0 - (dgy * f1(x0, y0) - dfy * f2(x0, y0)) / d;
                        double y1 = y0 - (-dgx * f1(x0, y0) + dfx * f2(x0, y0)) / d;
                        max = Math.Max(Math.Abs(x1 - x0), Math.Abs(y1 - y0));
                        n++;
                        x0 = x1;
                        y0 = y1;
                    } while (n <= limit && max > epsilon);
                    if (double.IsInfinity(x0) || double.IsInfinity(y0) || double.IsNaN(x0) || double.IsNaN(y0))
                        continue;
                    if (solX.Count == 0)
                    {
                        solX.Add(x0);
                        solY.Add(y0);
                    }
                    bool ok = true;
                    for (int l = 0; l < solX.Count; l++)
                    {
                        if (Math.Abs(solX[l] - x0) < 1e-5 && Math.Abs(solY[l] - y0) < 1e-5)
                        {
                            ok = false;
                        }
                    }
                    if (ok == true)
                    {
                        solX.Add(x0);
                        solY.Add(y0);
                    }
                }
            }
            for (int i = 0; i < solX.Count; i++)
            {
                dataGridView1.Rows.Add(solX[i], solY[i]);
            }
        }

        public double[] vector2 = {-1, -1/3.0, -1/5.0, -1/10.0, 0, 1/10.0, 1/5.0, 1/3.0, 1};

        public double[] vector3 = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        public double func(double x) => 1/(1 + 100*x*x);

        public double func2(double x) => Math.Pow(x, 10);


        private void lagrangeButton_Click(object sender, EventArgs e)
        {
            ClearGrid();
            dataGridView1.Columns.Add("Value", "Val");
            dataGridView1.Columns[0].Width = 300;
            double a = -3/2.0;
            double b = 3/2.0;
            int m = 20;
            double[] y=new double[m];
            double h = (b - a)/(m - 1);
            List<double> pp=new List<double>();
            for (int k = 0; k < m; k++)
            {
                y[k] = a + k*h;
                double p = 0;
                double prod = 1;
                for (int i = 0; i < vector2.Length; i++)
                {
                    prod = 1;
                    for (int j = 0; j<vector2.Length; j++)
                    {
                        if(i!=j)
                            prod *= (y[k] - vector2[j])/(vector2[i] - vector2[j]);
                    }
                    p += func(vector2[i])*prod;
                }
                pp.Add(p);
            }
            foreach (var p in pp)
            {
                dataGridView1.Rows.Add(p);
            }
        }

        private void newtonDiferente_Click(object sender, EventArgs e)
        {
            ClearGrid();
            dataGridView1.Columns.Add("Value", "Val");
            dataGridView1.Columns[0].Width = 300;
            double a = -3 / 2.0;
            double b = 3 / 2.0;
            int m = 20;
            double[] y = new double[m];
            double[] c = new double[vector2.Length];
            double[,] av=new double[vector2.Length,vector2.Length];
            double h = (b - a) / (m - 1);
            List<double> pp = new List<double>();
            double p = 0;
            for (int i = 0; i < vector2.Length; i++)
            {
                av[0, i] = func(vector2[i]);
            }
            c[0] = av[0, 0];
            double prod = 1;
            for (int i = 1; i < vector2.Length; i++)
            {
                prod = 1;
                for (int j = i; j < vector2.Length; j++)
                {
                    av[i, j] = (av[i - 1, j] - av[i - 1, j - 1]) / (vector2[j] - vector2[j - i]);
                }
                c[i] = av[i, i];
            }
            for (int i = 0; i < m; i++)
            {
                y[i] = a + i * h;
                p = c[vector2.Length-1];
                for (int j = vector2.Length-2; j >= 0; j--)
                {
                    p = p*(y[i] - vector2[j]) + c[j];
                }
                pp.Add(p);
            }
            foreach (var v in pp)
            {
                dataGridView1.Rows.Add(v);
            }
        }

        private double comb(double q ,int i )
        {
            if (i == 0)
                return 1;
            double prod = 1;
            for (int j = 0; j < i; j++)
            {
                prod *= (q - j + 1)/(j + 1);
            }
            return prod;

        }

        private double deltah(double n, double x, double h)
        {
            if (n == 0)
                return func2(x);
            return deltah(n - 1, x + h, h) - deltah(n - 1, x, h);
        }

        private void newtonAscendenta_Click(object sender, EventArgs e)
        {
            ClearGrid();
            dataGridView1.Columns.Add("Value", "Val");
            double a = 1;
            double b = 10;
            int m = 20;
            double x0 = 0;
            double h = 1;
            double[] y = new double[m];
            double hprim = (b - a) / (m - 1);
            List<double>pp=new List<double>();
            double p = 0;
            for (int k = 0; k < m; k++)
            {
                y[k] = x0 + k*hprim;
                double q = (y[k] - x0)/(k + 1);
                for (int i = 0; i < vector3.Length; i++)
                {
                    p += comb(q, i + 1)*deltah(i + 1, x0, h);
                }
                pp.Add(p);
            }
            foreach (var v in pp)
            {
                dataGridView1.Rows.Add(p);
            }
        }
    }
}
