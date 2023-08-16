using System;
using System.Windows;
using System.Threading;
using System.Text;

namespace Development
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            add_button.Click += Add_Click;
            minus_button.Click += Minus_Click;
            multiply_button.Click += Multiply_Click;
            divide_button.Click += Divide_Click;
            powerraise_button.Click += Power_Click;
            squareroot_button.Click += Squareroot_Click;
            log_button.Click += Log_Click;
            factorial_button.Click += Factorial_Click;
            tan_button.Click += Tan_Click;
            sin_button.Click += Sin_Click;
            cos_button.Click += Cos_Click;
            pi_button.Click += Pi_Click;
            clear_button.Click += Clear_Click;
            on_button.Click += On_Click;


        }

        private void On_Click(object sender, EventArgs e)
        {

        }


        private void Clear_Click(object sender, EventArgs e)
        {
            int i = 0;
            int j = 0;
            for (i = 1; i < 2; i++)
            {
                input1.Text = input2.Text = alert.Text = result.Text = "";
                Thread.Sleep(100);
                alert.Text = "Console is Cleared";
                Thread.Sleep(50);
                j++;
            }
        }


        private void Add_Click(object sender, EventArgs e)
        {
            float i, j;
            double pi = 3.14;

            if(input1.Text == pi.ToString())
            {
                i = float.Parse(input1.Text);
                double resultAdd = i + pi;
                result.Text = resultAdd.ToString();
                alert.Text = "Action Performed is Addition";
            }
            else if (input1.Text == pi.ToString())
            {
                j = float.Parse(input2.Text);
                double resultAdd = j + pi;
                result.Text = resultAdd.ToString();
                alert.Text = "Action Performed is Addition";
            }
            else if(input1.Text == "" && input2.Text =="")
            {
                alert.Text = "Alert: Please Enter Value!";
            }
            else if(input1.Text != "" && input2.Text == "")
            {
                i = float.Parse(input1.Text);
                float k = 0;
                double resultAdd = i + k;
                result.Text = resultAdd.ToString();
                alert.Text = "Action Performed is Addition";
            }
            else if (input1.Text == "" && input2.Text != "")
            {
                j = float.Parse(input2.Text);
                float k = 0;
                double resultAdd = j + k;
                result.Text = resultAdd.ToString();
                alert.Text = "Action Performed is Addition";
            }
            else
            {
                i = float.Parse(input1.Text);
                j = float.Parse(input2.Text);
                float resultAdd = i + j;
                result.Text = resultAdd.ToString();
                alert.Text = "Action Performed is Addition";
            }


        }







        private void Minus_Click(object sender, EventArgs e)
        {
            float i, j;
            double pi = 3.14;

            if (input1.Text == pi.ToString())
            {
                i = float.Parse(input1.Text);
                double resultSub = i - pi;
                result.Text = resultSub.ToString();
                alert.Text = "Action Performed is Substraction";
            }
            else if (input1.Text == pi.ToString())
            {
                j = float.Parse(input2.Text);
                double resultSub = j - pi;
                result.Text = resultSub.ToString();
                alert.Text = "Action Performed is Substraction";
            }
            else if (input1.Text == "" && input2.Text == "")
            {
                alert.Text = "Alert: Please Enter Value!";
            }
            else if (input1.Text != "" && input2.Text == "")
            {
                i = float.Parse(input1.Text);
                float k = 0;
                double resultSub = i - k;
                result.Text = resultSub.ToString();
                alert.Text = "Action Performed is Substraction";
            }
            else if (input1.Text == "" && input2.Text != "")
            {
                j = float.Parse(input2.Text);
                float k = 0;
                double resultSub = j - k;
                result.Text = resultSub.ToString();
                alert.Text = "Action Performed is Substraction";
            }
            else
            {
                i = float.Parse(input1.Text);
                j = float.Parse(input2.Text);
                float resultSub = i - j;
                result.Text = resultSub.ToString();
                alert.Text = "Action Performed is Substraction";
            }


        }

        private void Multiply_Click(object sender, EventArgs e)
        {

        }

        private void Divide_Click(object sender, EventArgs e)
        {

        }

        private void Power_Click(object sender, EventArgs e)
        {

        }

        private void Squareroot_Click(object sender, EventArgs e)
        {

        }

        private void Log_Click(object sender, EventArgs e)
        {

        }

        private void Factorial_Click(object sender, EventArgs e)
        {

        }

        private void Tan_Click(object sender, EventArgs e)
        {

        }

        private void Sin_Click(object sender, EventArgs e)
        {

        }

        private void Cos_Click(object sender, EventArgs e)
        {

        }

        private void Pi_Click(object sender, EventArgs e)
        {
            double pi = 3.14;

            if(input1.Text != "" && input2.Text != "")
            {
                MessageBox.Show("Alert: Values Already Present Please Clear Console or Any One Field");
            }
            else if(input2.Text != "")
            {
                input1.Text = pi.ToString();
                alert.Text = "Pi Value 3.14 is Used";
            }
            else if(input1.Text != "")
            {
                input2.Text = pi.ToString();
                alert.Text = "Pi Value 3.14 is Used";
            }
            else if(input1.Text == "" && input2.Text == "")
            {
                alert.Text = "Alert: Please Enter Value!";
            }

        }


    }
}
