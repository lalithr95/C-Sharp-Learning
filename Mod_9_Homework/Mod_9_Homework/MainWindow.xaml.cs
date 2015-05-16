using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mod_9_Homework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> list;
        int current = 0;
        public MainWindow()
        {
            InitializeComponent();
            list = new List<Student>();
        }

        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            string firstname = txtFirstName.Text;
            string lastname = txtLastName.Text;
            string city = txtCity.Text;
            Student s = new Student(firstname, lastname, city);
            list.Add(s);
            MessageBox.Show("Student Added");
            txtCity.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            current++;
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            if(current <= 0)
            {
                btnPrevious.IsEnabled = false;

            }
            else
            {
                current--;
                txtLastName.Text = list[current].Lastname;
                txtFirstName.Text = list[current].Firstname;
                txtCity.Text = list[current].City;
                btnNext.IsEnabled = true;
            }
            
            
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (current >= (list.Count -1))
            {
                btnNext.IsEnabled = false;
            }
            else
            {
                current++;
                txtCity.Text = list[current].City;
                txtFirstName.Text = list[current].Firstname;
                txtLastName.Text = list[current].Lastname;
                btnPrevious.IsEnabled = true;
            }

        }
    }
}
