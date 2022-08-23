using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuresAndEnumsDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Students s1 = new Students();
            Console.WriteLine("Enter Rollno");
            s1.Rollno=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name of the student");
            s1.StudentName = Console.ReadLine();
            Console.WriteLine("Enter Admission Date of the student");
            s1.AdmissionDate = Convert.ToDateTime(Console.ReadLine());



            Console.WriteLine("Printing Student Details");
            int myRollno=s1.Rollno;
            Console.WriteLine(myRollno);
            Console.WriteLine(s1.StudentName);
            Console.WriteLine(s1.AdmissionDate);
            //Console.WriteLine(s1.Rollno);



            //creating bk1 object of type Books(struct) on the stack.
            //new keyword
            //Books bk1=new Books();
            ////Books bk2 = new Books(14, "C++");

            //Console.WriteLine("Enter Bookid");
            //bk1.BookIdentifier= Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Price");
            //float b_price= Convert.ToSingle(Console.ReadLine());

            //Console.WriteLine("Enter BookName");
            //string b_name= Console.ReadLine();

            //Console.WriteLine("Enter Pages");
            //int b_pages = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Author");
            //string b_auname = Console.ReadLine();

            //Console.WriteLine("Enter Subject");
            //string b_subname = Console.ReadLine();

            //bk1.AcceptBookData(b_id, b_name, b_auname, b_subname, b_pages ,b_price);
            //Console.WriteLine("Now Printing the data");
            //bk1.DisplayInfo();

            //Books bk2;

            //specifications for bk1
            //bk1.Bookid = 101;
            //bk1.BookName = "C#";
            //bk1.NoOfPages = 500;
            //bk1.Price = 1000.00f;
            //bk1.Subject = ".NET";
            //bk1.Author = "Gonsalvis";


            //bk2.Bookid = 102;
            //bk2.BookName = "Networking Basics";
            //bk2.NoOfPages =670;
            //bk2.Price = 1200.50f;
            //bk2.Subject = "Networks";
            //bk2.Author = "Jack";

            //Console.WriteLine("Now Printing the details");

            //Console.WriteLine("First Book");
            //Console.WriteLine(bk1.Bookid);
            //Console.WriteLine(bk1.BookName);
            //Console.WriteLine(bk1.Author);
            //Console.WriteLine(bk1.NoOfPages);
            //Console.WriteLine(bk1.Subject);
            //Console.WriteLine(bk1.Price);

            //Console.WriteLine("-----------------");
            //Console.WriteLine("Second Book");
            //Console.WriteLine(bk2.Bookid);
            //Console.WriteLine(bk2.BookName);
            //Console.WriteLine(bk2.Author);
            //Console.WriteLine(bk2.NoOfPages);
            //Console.WriteLine(bk2.Subject);
            //Console.WriteLine(bk2.Price);

            Console.Read();



        }
    }
}
