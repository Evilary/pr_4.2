

using System.Collections.Generic;

namespace Constructions_Chenyshkov2.Classes
{
    public class RepoStudent
    {
        public static List<Student> AllStudents() {
            List<Student> AllStudents = new List<Student>();

            AllStudents.Add(new Student("Иванов", "Алексей", "Петрович", true, 3));
            AllStudents.Add(new Student("Смирнова", "Елена", "Сергеевна"));
            AllStudents.Add(new Student("Петров", "Михаил", "Дмитриевич", false, 4));
            AllStudents.Add(new Student("Кузнецова", "Анна", "Викторовна"));
            AllStudents.Add(new Student("Сидоров", "Игорь", "Николаевич"));
            AllStudents.Add(new Student("Васильева", "Ольга", "Андреевна"));
            AllStudents.Add(new Student("Попов", "Дмитрий", "Александрович"));
            AllStudents.Add(new Student("Лебедева", "Наталья", "Иванovna"));
            AllStudents.Add(new Student("Соколов", "Павел", "Сергеевич"));
            AllStudents.Add(new Student("Козлова", "Татьяна", "Михайловна", true, 4));
            AllStudents.Add(new Student("Новиков", "Максим", "Романович"));
            AllStudents.Add(new Student("Морозова", "Юлия", "Алексеевна"));
            AllStudents.Add(new Student("Зайцев", "Владимир", "Геннадьевич"));
            AllStudents.Add(new Student("Орлова", "Марина", "Олеговна"));
            AllStudents.Add(new Student("Волков", "Евгений", "Константинович", false, 4));
            AllStudents.Add(new Student("Соловьева", "Ирина", "Борисовна"));
            AllStudents.Add(new Student("Семенов", "Роман", "Владимирович", true, 4));
            AllStudents.Add(new Student("Беляева", "Виктория", "Павловна"));
            AllStudents.Add(new Student("Федоров", "Константин", "Юрьевич"));
            AllStudents.Add(new Student("Александрова", "Полина", "Вячеславовна"));
            AllStudents.Add(new Student("Кузнецов", "Станислав", "Леонидович"));
            AllStudents.Add(new Student("Быкова", "Дарья", "Евгеньевна"));
            AllStudents.Add(new Student("Яковлев", "Григорий", "Алексеевич", false, 4));
            AllStudents.Add(new Student("Иванов", "Алексей", "Петрович", true, 3));
            AllStudents.Add(new Student("Смирнова", "Елена", "Сергеевна"));
            AllStudents.Add(new Student("Петров", "Михаил", "Дмитриевич", false, 4));
            AllStudents.Add(new Student("Кузнецова", "Анна", "Викторовна"));
            AllStudents.Add(new Student("Сидоров", "Игорь", "Николаевич"));
            AllStudents.Add(new Student("Васильева", "Ольга", "Андреевна"));
            AllStudents.Add(new Student("Попов", "Дмитрий", "Александрович"));
            AllStudents.Add(new Student("Лебедева", "Наталья", "Иванovna"));
            AllStudents.Add(new Student("Соколов", "Павел", "Сергеевич"));
            AllStudents.Add(new Student("Козлова", "Татьяна", "Михайловна", true, 4));
            AllStudents.Add(new Student("Новиков", "Максим", "Романович"));
            AllStudents.Add(new Student("Морозова", "Юлия", "Алексеевна"));
            AllStudents.Add(new Student("Зайцев", "Владимир", "Геннадьевич"));
            AllStudents.Add(new Student("Орлова", "Марина", "Олеговна"));
            AllStudents.Add(new Student("Волков", "Евгений", "Константинович", false, 4));
            AllStudents.Add(new Student("Соловьева", "Ирина", "Борисовна"));
            AllStudents.Add(new Student("Семенов", "Роман", "Владимирович", true, 4));
            AllStudents.Add(new Student("Беляева", "Виктория", "Павловна"));
            AllStudents.Add(new Student("Федоров", "Константин", "Юрьевич"));
            AllStudents.Add(new Student("Александрова", "Полина", "Вячеславовна"));
            AllStudents.Add(new Student("Кузнецов", "Станислав", "Леонидович"));
            AllStudents.Add(new Student("Быкова", "Дарья", "Евгеньевна"));
            AllStudents.Add(new Student("Яковлев", "Григорий", "Алексеевич", false, 4));

            return AllStudents;
        }
    }
}
