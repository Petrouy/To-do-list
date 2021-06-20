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
using System.IO;
using System.Collections.ObjectModel;

namespace Užitečný_software_To_Do_List_Barvík
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Tasks.initializeTasks();
            Tasks t = new Tasks();
            DataContext = t;
        }



        private void ActiveHomeworks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Tasks ts = (Tasks)((sender as ListView).SelectedItem);
            DataContext = ts;
        }


        private void ActiveHomeworks_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Tasks ts = (Tasks)((sender as ListView).SelectedItem);
            ChangeHomework chh = new ChangeHomework(ts);
            chh.ShowDialog();
        }


        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddHomework ah = new AddHomework();
            ah.ShowDialog();

        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter stw = new StreamWriter("hw1.txt");

            stw.WriteLine(LblName.Content);
            stw.WriteLine(LblTime.Content);
            stw.WriteLine(LblPlace.Content);
            stw.WriteLine(LblFriends.Content);
            stw.WriteLine(LblComment.Content);

            stw.Close();

        }

        private void SaveButton_Click2(object sender, RoutedEventArgs e)
        {
            StreamWriter stw = new StreamWriter("hw2.txt");

            stw.WriteLine(LblName.Content);
            stw.WriteLine(LblTime.Content);
            stw.WriteLine(LblPlace.Content);
            stw.WriteLine(LblFriends.Content);
            stw.WriteLine(LblComment.Content);

            stw.Close();

        }

        private void SaveButton_Click3(object sender, RoutedEventArgs e)
        {
            StreamWriter stw = new StreamWriter("hw3.txt");

            stw.WriteLine(LblName.Content);
            stw.WriteLine(LblTime.Content);
            stw.WriteLine(LblPlace.Content);
            stw.WriteLine(LblFriends.Content);
            stw.WriteLine(LblComment.Content);

            stw.Close();
           
        }

        //Finished homeworks

        private void FinishedHomeworks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Tasks ts = (Tasks)((sender as ListView).SelectedItem);
            DataContext = ts;
        }


        private void FinishedHomeworks_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Tasks.AllTasks.Add((Tasks)DataContext);
            //Tasks.FinishedTasks.RemoveAt(Tasks.FinishedTasks.IndexOf((Tasks)DataContext));
        }

    }
}
