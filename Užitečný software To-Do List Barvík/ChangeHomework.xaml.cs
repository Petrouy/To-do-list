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
using System.Windows.Shapes;

namespace Užitečný_software_To_Do_List_Barvík
{
    /// <summary>
    /// Interakční logika pro ChangeHomework.xaml
    /// </summary>
    public partial class ChangeHomework : Window
    {
        public ChangeHomework()
        {
            InitializeComponent();
            DataContext = new Tasks();
            IsUpdate = false;
        }

        bool IsUpdate { get; set; }


        public ChangeHomework(Tasks t)
        {
            InitializeComponent();
            DataContext = t;
            IsUpdate = true;
        }


        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (IsUpdate == false)
            {
                Tasks.AllTasks.Add((Tasks)DataContext);
            }
            this.Close();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Tasks.AllTasks.RemoveAt(Tasks.FinishedTasks.IndexOf((Tasks)DataContext));
            this.Close();
        }

        private void DoneButton_Click(object sender, RoutedEventArgs e)
        {
            Tasks.FinishedTasks.Add((Tasks)DataContext);
            this.Close();
        }


    }
}
