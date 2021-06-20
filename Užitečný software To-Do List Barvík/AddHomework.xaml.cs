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
using System.IO;

namespace Užitečný_software_To_Do_List_Barvík
{
    /// <summary>
    /// Interakční logika pro AddHomework.xaml
    /// </summary>
    public partial class AddHomework : Window
    {
        public AddHomework()
        {
            InitializeComponent();
            DataContext = new Tasks();
            IsUpdate = false;
        }

        bool IsUpdate { get; set; }


        public AddHomework(Tasks t)
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

                StreamWriter sw = new StreamWriter("Tasks.txt");
                for (int i = 0; i < Tasks.AllTasks.Count; i++)
                {
                    sw.WriteLine(Tasks.AllTasks);
                }
                sw.Close();

                //File.AppendText("Tasks.txt");
                //File.WriteAllText("Tasks.txt", Convert.ToString((Tasks)DataContext));
            }
            this.Close();
        }

    }
}
