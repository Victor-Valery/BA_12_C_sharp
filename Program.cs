using System;

namespace BA_12_C_sharp //siniflardan olusan isim uzayi
{
    // 1. SINIF
    // 2. NESNE
    // 3. ÖZELLIKLERI VE DAVRANISLARI

    public class Student
    {
        //private int studentID;

        //public int StudentID
        //{
        //    get { return studentID; }
        //    set {

        //        if (value < 1000)
        //        {
        //            Console.WriteLine($"GIRILEN NUMARA {value} DIR. ÖGRENCI NUMARASI 1000'DEN KÜCÜK OLAMAZ");
        //            studentID = 0;
        //        }
        //        else
        //        {
        //            studentID = value;
        //        }

        //    }
        //}


        public int StudentID { get; set; }  // properties , **ABSTRACTION

        public string Name { get; set; }

        public string Surname { get; set; }

        public string SchoolName { get; set; }

        public void PrintStudent()
        {
            Console.WriteLine($"ADI: {this.Name}\nSOYADI: {this.Surname}\nOKUL ADI: {this.SchoolName}\nOKUL NUMARASI: {this.StudentID}");
        }

        public double Topla(double a, double b)
        {
            double sonuc = a + b;
            Console.WriteLine(sonuc);
            return sonuc;
        }

        public double Carpma(double x, double y)
        {
            double sonuc = x * y;
            Console.WriteLine(sonuc);
            return sonuc;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(); //sinifin kopyasi (instance)..
            s1.StudentID = 1000;
            s1.Name = "Ali";
            s1.Surname = "Can";
            s1.SchoolName = "Atatürk Ilkögretim";
            s1.PrintStudent();

            Console.WriteLine("*********************************");

            Student s2 = new Student();
            s2.StudentID = 1001;
            s2.Name = "Ahmet";
            s2.Surname = "Tan";
            s2.SchoolName = "Cumhuriyet Ilkögretim";
            s2.PrintStudent();

            Console.WriteLine($"ADI: {s1.Name} \nSOYADI: {s1.Surname}");

            Console.WriteLine("*********************************");

            s1.Topla(6.98, 7.99);
            s1.Topla(1000, 988);
            s1.Carpma(9, 8);


        }
    }
}
