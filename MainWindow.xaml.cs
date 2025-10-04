using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Constructions_Chenyshkov2.Classes;

namespace Constructions_Chenyshkov2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Classes.Student> AllStudents = RepoStudent.AllStudents();
        public int Count = 10;
        public int Step = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        public void CreateStudents()
        {
            for (int iStudent = Step; iStudent < Step; iStudent++)
            {
                if (AllStudents.Count > iStudent)
                {
                    parent.Children.Add(new Elements.Student(AllStudents[iStudent]));
                }
            }

            this.Step += Count;
        }
        private void ScrollViewer_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            ScrollViewer scroll = sender as ScrollViewer;
            double ParentHeight = parent.ActualHeight;
            double WindowHeight = scroll.ActualHeight - 20;
            double DeltaHeight = ParentHeight - WindowHeight;

            if (DeltaHeight - scroll.VerticalOffset < 140)
                CreateStudents();

        }
    }
}
