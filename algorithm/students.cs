class Student
{
    public static void FindStudentByYear(Student student, string year)
    {
        if (student._year == year)
        {
            Console.WriteLine($"ФИО: {student.FIO}, Группа: {student.Group}, Год: {student.Year}");
        }
    }
    public static void FindStudentByGroup(Student student, string group)
    {
        if (student._group == group)
        {
            Console.WriteLine($"ФИО: {student.FIO}, Группа: {student.Group}, Год: {student.Year}");
        }
    }
    string _fio, _group, _year;
 
    public Student(string fio, string group, string year)
    {
        this._fio = fio;
        this._group = group;
        this._year = year;
    }

   
    public string FIO
    {
        set { this._fio = value; }
        get { return this._fio; }
    }
    public string Group
    {
        set { this._group = value; }
        get { return this._group; }
    }
    public string Year
    {
        set { this._year = value; }
        get { return this._year; }
    }

}

class Program
{
    static void Main()
    {
        Student[] students = new Student[3];
        students[0] = new Student("ФИО1", "FIT-231", "2004");
        students[1] = new Student("ФИО2", "FIT-232", "2005");
        students[2] = new Student("ФИО3", "FIT-231", "2005");
        Console.WriteLine("Введите тип фильтра ('y' для фильтра по году рождения студента, 'g' для фильтра по группе студента)");

        string filter = Console.ReadLine();

        if (filter == "y")
        {
            Console.Write("Введите год рождения студента: ");
            string studentYear = Console.ReadLine();
            foreach (Student student in students)
            {
                Student.FindStudentByYear(student, studentYear);
            }
        }
        else if (filter == "g")
        {
            Console.Write("Введите группу студента: ");
            string studentGroup = Console.ReadLine();

            foreach (Student student in students)
            {
                Student.FindStudentByGroup(student, studentGroup);
            }
        }
    }
}
