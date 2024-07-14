using System; 
using System.ComponentModel.Design;
using System.Xml.Linq;


namespace Lab3
{
    #region task1
    //class Student
    //{
    //    int id;
    //    string name;
    //    int age;
    //    public void getData(int Id, string Name, int Age)
    //    {
    //        id = Id;
    //        name = Name;
    //        age = Age;

    //    }
    //    public void print()
    //    {
    //        Console.WriteLine($" {id} - {name} - {age}");
    //    }
    //    public string isPensionAge()
    //    {
    //        if (age > 60)
    //            return "He reached a pension age";

    //        return "He didn't reach a pension age";
    //    }
    //}

    //class Progrm
    //{
    //    static void Main()
    //    {
    //        Student Stud1 = new Student(); 
    //        Stud1.getData(1, "Nour", 22);

    //        string isPensionAge = Stud1.isPensionAge();
    //        Console.WriteLine(isPensionAge);

    //        Stud1.print();
    //    }
    //}
    #endregion


    #region task2
    //    class Student(int id, string name, int age)
    //    {
    //        static Student();
    //        {
    //        Console.WriteLine("Hello");
    //            }
    //    public void print()
    //    {
    //        Console.WriteLine($" {id} - {name} - {age}");
    //    }

    //}

    //class Progrm
    //    {
    //        static void Main()
    //        {
    //            Student Stud1 = new Student(1, "Nour", 22);
    //            Student Stud2 = new Student(2, "Nour", 21);
    //            Student Stud3 = new Student(3, "Mohamed", 60);
    //            Student Stud4 = new Student(4, "Esmail", 80);

    //        }
    //}

    #endregion
}




#region Task3
class Student   // The method "Count" doesn't exist here so i can't find the right  solution without trying , i tried but i can't.......
{
    int id;
    string name;
    string type;
    bool isDeleted;
    string price;

    public void getData(int Id, string Name, string Type,bool isDeleted, string Price )
    {
        id = Id;
        name = Name;
        type = Type;
        price = Price;

    }
    public void print()
    {
        Console.WriteLine($" {id} - {name} - {type} - {isDeleted} - {price}");
    }
    public void is_Deleted()
    {

        if (isDeleted == true)
            return Count;
            //Console.Write($"Sold : ");
            //else
            //Console.Write($"not sold ");
    }
}

class Progrm
{
    static void Main()
    {
        Student Stud1 = new Student();
        Stud1.getData(1, "Nour", "22A", true, "1000");
        Stud1.print();

        Student Stud2 = new Student();
        Stud1.getData(1, "Nour", "22e", false, "1000");
        Stud1.print();

        Student Stud3 = new Student();
        Stud1.getData(1, "Nour", "2q2", true, "1000");
        Stud1.print();

        Student Stud4 = new Student();
        Stud1.getData(1, "Nour", "22d", true, "1000");
        Stud1.print();

        Console.WriteLine(Student.Count);

    }
}
    #endregion

