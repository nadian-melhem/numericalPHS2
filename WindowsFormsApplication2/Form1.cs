using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        double xPrev;
        double yPrev;
        double xNew, yNew;
        public Form1()
        {
            InitializeComponent();
                       
        }

        private void run_Click(object sender, EventArgs e)
        {
            int i = int.Parse(numOfIterations.Text);
            xPrev = double.Parse(xZero.Text);
            yPrev = double.Parse(yZero.Text);
            while (i>0)
            {
                xNew = xPrev - ((u(xPrev, yPrev) * divVy(xPrev, yPrev) - v(xPrev, yPrev) * divUy(xPrev, yPrev)) / jacobian(xPrev, yPrev));
                yNew = xPrev - ((v(xPrev, yPrev) * divUx(xPrev, yPrev) - u(xPrev, yPrev) * divVx(xPrev, yPrev)) / jacobian(xPrev, yPrev));
                xPrev = xNew;
                yPrev = yNew;
                i--;

            }
            if (xNew.ToString() != "NaN"|| yFinal.ToString() != "NaN")
            {
                xFinal.Text = xNew.ToString();
                yFinal.Text = yNew.ToString();
            }
            else
                MessageBox.Show("Please Try another intervel");
        }
        private double u(double x,double y)
        {
            return Math.Pow(x-1,3)+(0.512/y);
        }
        private double v(double x, double y)
        {
            return x - 2 * Math.Sqrt(x * y);
        }
        private double divUx(double x,double y)
        {
            return 3 * Math.Pow(x - 1, 2);
        }
        private double divUy(double x,double y)
        {
            return -(0.512 / Math.Pow(y, 2));
        }
        private double divVx(double x,double y)
        {
            return 1 -( y / Math.Pow(x * y, 0.5));
        }
        private double divVy(double x, double y)
        {
            return -x / Math.Pow(x*y, 0.5);
        }
        private  double jacobian(double x, double y)
        {
            return (divUx(x, y) * divVy(x, y)) - (divUy(x, y) * divVx(x, y));
        }

        
    }
}
