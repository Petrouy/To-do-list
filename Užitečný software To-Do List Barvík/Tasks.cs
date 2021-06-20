using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.IO;

namespace Užitečný_software_To_Do_List_Barvík
{
    public class Tasks : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;



        private string name;
        public string Name
        {
            get => name;
            set { name = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name")); }
        }

        private string time;
        public string Time
        {
            get => time;
            set { time = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Time")); }
        }

        private string place;
        public string Place
        {
            get => place;
            set { place = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Place")); }
        }

        private string friends;
        public string Friends
        {
            get => friends;
            set { friends = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Friends")); }
        }

        private string comment;
        public string Comment
        {
            get => comment;
            set { comment = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Comment")); }
        }




        public static ObservableCollection<Tasks> AllTasks { get; set; } = new ObservableCollection<Tasks>();   //Active tasks

        public static ObservableCollection<Tasks> FinishedTasks { get; set; } = new ObservableCollection<Tasks>();    //Finished tasks



        public static void initializeTasks()
        {
            AllTasks.Add(new Tasks
            {
                Name = "Meeting with John",
                Time = "11:30",
                Place = "Local Restaurant",
                Friends = "John",
                Comment = "Take your suitcase"
            });

            AllTasks.Add(new Tasks
            {
                Name = "Math Homework",
                Time = "till 23:59",
                Place = "Home",
                Friends = "-",
                Comment = "Page 153"
            });
        }


    }
}
