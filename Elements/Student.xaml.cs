using System.Windows.Controls;

namespace Constructions_Chenyshkov2.Elements
{
    /// <summary>
    /// Логика взаимодействия для Student.xaml
    /// </summary>
    public partial class Student : UserControl
    {
        public Student(Classes.Student student)
        {
            InitializeComponent();
            tbf10.Content = student.GetFIO();
            tbfSchoolarship.Content = student.Schoolarship ? "Степендия: получает" : "Степендия: получает";
            tbfCourse.Content = $"Курс: {student.Course}";
        }
    }
}
