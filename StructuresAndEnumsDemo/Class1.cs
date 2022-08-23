using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuresAndEnumsDemo
{
    class Class1
    {
    }


    struct SiteUser
    {
        //WriteOnly property
        string _pwd;
        public string Password
        {
            set { _pwd = value; }//assign a password


        }

        string _verifycaptcha;
        public string VerifyCaptcha
        {
            set {
                _verifycaptcha = value;
                if (_verifycaptcha == _c)
                {
                    Console.WriteLine("Valid");
                }
                else
                {
                    Console.WriteLine("Invalid");
                }

            }
        }

        string _c;
        public void WorkWithCaptcha()
        {
            _c = "AFH876";
            Console.WriteLine(_c);
        }
        
    //    //Writeonly
    //    string _c;
    //    public string SetCaptcha
    //    {
    //        set {
    //            _c = value;
    //        }
    //    }


   

    ////Readonly
    //    public string ShowCaptcha
    //    {
           
    //        get {
    //            SetCaptcha= "AFH876";
    //            return _c;
    //                }
        
    //    }


    }


    struct Students
    {
        int _rollno;//field/variable
        public int Rollno
        {
            get
            {

                return _rollno;
            }
            set 
            {
                _rollno = value;
            
            }
        }

        string _studname;//field
        public string StudentName
        {
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Name cannot be null or empty");

                }
                else
                {
                    _studname = value;
                }
            }
            get 
            {
                
                return _studname; 
            
            }
           
        }




        DateTime _admissionDate;
        public DateTime AdmissionDate
        {
            get { return _admissionDate; }
            set { _admissionDate = value; }

        }







    }





    //outline/template 
    struct Books
    {
         int Bookid;
         string BookName;
         string Author;
         //string Subject;
         //int NoOfPages;
         //float Price;

        




        public Books(int Bookid, string _bookname,string _author)
        {
           this.Bookid = Bookid;
            BookName = _bookname;
            Author = _author;
            Console.WriteLine(Bookid);
            Console.WriteLine(BookName);
        }








        public void AcceptBookData(int bookid, string bookname, string author, string subject, int pages, float price)
        {
            Bookid = bookid;
            BookName = bookname;
            //Author = author;
            //Subject = subject;
            //NoOfPages = pages;
            //Price = price;

        }

        public void DisplayInfo()
        {
            Console.WriteLine(Bookid);
            Console.WriteLine(BookName);
            //Console.WriteLine(Author);
            //Console.WriteLine(NoOfPages);
            //Console.WriteLine(Subject);
            //Console.WriteLine(Price);

        }


    }






}
