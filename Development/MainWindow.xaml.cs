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


        }

        private void Add_Click(object sender, EventArgs e)
        {

        }

        private void Minus_Click(object sender, EventArgs e)
        {

        }

        private void Multiply_Click(object sender, EventArgs e)
        {

        }



    }
}
