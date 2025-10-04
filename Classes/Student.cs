namespace Constructions_Chenyshkov2.Classes
{
    public class Student
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Surname { get; set; }
        public bool Schoolarship { get; set; }
        public int Course = 4;

        public Student( string Firstname, string Lastname, string Surname) {
            this.Firstname = Firstname;
            this.Surname = Surname;
            this.Lastname = Lastname;
        
        }
        public Student(string Firstname, string Lastname, string Surname, bool Schoolarship)
            :this(Firstname, Lastname, Surname) {
            this.Schoolarship = Schoolarship;   
        }

        public Student(string Firstname, string Lastname, string Surname, bool Schoolarship, int Course)
            : this(Firstname, Lastname, Surname)
        {
            this.Course = Course;
        }

        public string GetFIO() {
            return $"{Lastname}{Firstname}{Surname}";
        }

    }
}
