using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//The Pattern Matching is a mechanism which tests a value i.e. whether the value has a specific shape or not
//Pattern Matching using the “is” expression
//Pattern Matching using the “case” statements
namespace PatternMatching
{
    //using is expression
    class Student
    {
        //create 1 property and assign value to it
        public string Name { get; set; } = "roshi dubey";

        //now gotto main method
    }

    //----------------------------------------------
    //using switch case expression
    class Teacher
    {
        //create 2 property and assign value to it
        public string Name { get; set; } = "ravi";
        public string Qual { get; set; } = "phd";
    }


    //---------------------------------------------
    class Program
    {
        static void Main(string[] args)
        {
            Student ss = new Student();
            if(ss is Student)
            {
                Console.WriteLine(ss.Name);
                Console.ReadLine();
            }
            //----------------------------------------------

            //for switch case, first create static method using switch case
            //then instantiate it
            Teacher tt = new Teacher();
            Swit(tt);
            Console.ReadLine();
        }

        //-----------------------------------------------
        //now for switch case , create 1 static method
        public static void Swit(object ob)
        {
            switch (ob)
            {
                case Student ss: 
                    Console.WriteLine(ss.Name);
                    break;

                case Teacher tt:
                    Console.WriteLine(tt.Name);
                    Console.WriteLine(tt.Qual);
                    break;

                default:
                    throw new ArgumentException(
                        
                        );
            }
        }
    }
}
