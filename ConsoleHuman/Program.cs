using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleHuman
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            List<Employee> employees = new List<Employee>();
            while (true)
            {
                Console.WriteLine("1-Add student   2-Add employee   3-Search   4-Exit");
                Console.WriteLine("Choose option");
                string result = Console.ReadLine();
                bool isInt = int.TryParse(result, out int menu);
                if (isInt && menu >= 1 && menu <= 4)
                {
                    if (menu == 4)
                    {
                        break;
                    }
                    switch (menu)
                    {


                        case 1:
                            CREATESTUDENT:
                            Student st = new Student();
                            Console.Write("Enter student name : ");
                            st.Name = Console.ReadLine();
                            
                            Console.Write("Enter student surname : ");
                        INPUTAGE: st.Surname = Console.ReadLine();

                            Console.Write("Enter student age : ");

                            result = Console.ReadLine();
                            bool isStAge = int.TryParse(result, out int stage);
                            if (!isStAge)
                            {
                                Console.WriteLine("Enter correctly");
                                goto INPUTAGE;
                            }
                            st.Age = stage;
                        INPUTGRADE: Console.Write("Enter student grade : ");

                            result = Console.ReadLine();
                            bool isStGrade = int.TryParse(result, out int grade);
                            if (!isStGrade)
                            {
                                Console.WriteLine("Enter correctly");
                                goto INPUTGRADE;
                            }
                            st.Grade = grade;
                            students.Add(st);
                            Console.Write("Do you want to add new Student? (yes/no)  :  ");
                            string answer1 = Console.ReadLine();
                            Console.WriteLine();
                            if (answer1.ToLower() == "yes")
                            {
                                goto CREATESTUDENT;
                            }
                            break;



                        case 2:
                            CREATEEMPLOYEE:
                            Employee emp = new Employee();
                            Console.Write("Enter employee name : ");
                            emp.Name = Console.ReadLine();
                            Console.Write("Enter employee surname : ");
                            emp.Surname = Console.ReadLine();
                        INPUTEMPAGE: Console.Write("Enter employee age : ");

                            result = Console.ReadLine();
                            bool isEmpAge = int.TryParse(result, out int empage);
                            if (!isEmpAge)
                            {
                                Console.WriteLine("Enter correctly");
                                goto INPUTEMPAGE;
                            }
                        Console.Write("Enter employee position : ");
                            emp.Position = Console.ReadLine();  
                            
                            employees.Add(emp);
                            Console.Write("Do you want to add new Employee? (yes/no)  :  ");
                            Console.WriteLine();
                            string answer2 = Console.ReadLine();
                            if (answer2.ToLower()=="yes")
                            {
                                goto CREATEEMPLOYEE;
                            }
                            break;


                        case 3:
                            Console.WriteLine("1-Search Employee   2-Search Student");
                            Console.WriteLine("Choose option");
                            string menu2 = Console.ReadLine();
                            bool isMenu = int.TryParse(menu2, out int secondmenu);
                            if (isMenu && secondmenu >= 1 && secondmenu <= 2)
                            {
                                switch (secondmenu)
                                {
                                    case 1:
                                        Console.Write("Enter position of employee which you want to search : ");
                                        string pos = Console.ReadLine();
                                        foreach (var item in employees)
                                        {
                                            if (item.Position==pos)
                                            {
                                                Console.WriteLine($"Employee name : {item.Name}");
                                            }
                                        }                                      
                                        break;
                                    case 2:
                                        INPUTMIN:
                                        Console.Write("Enter minimum grade of student which you want to search : ");
                                        string resultgr = Console.ReadLine();
                                        bool IsMin = int.TryParse(resultgr, out int MinGrade);
                                        if (!IsMin)
                                        {
                                            Console.WriteLine("Enter correctly!");
                                            goto INPUTMIN;
                                        }
                                        INPUTMAX:
                                        Console.Write("Enter maximum grade of student which you want to search : ");
                                        string resultmx = Console.ReadLine();
                                        bool IsMax = int.TryParse(resultmx, out int MaxGrade);
                                        if (!IsMax)
                                        {
                                            Console.WriteLine("Enter correctly!");
                                            goto INPUTMAX;
                                        }
                                        foreach (var item in students)
                                        {
                                            if(item.Grade<=MaxGrade && item.Grade >= MinGrade)
                                            {
                                                Console.WriteLine($"Student name : {item.Name},  Grade : {item.Grade}");
                                            }
                                        }
                                        break;
                                    default:
                                        break;
                                }

                            }
                            break;
                        default:
                            break;
                    }
                }
            }

        }
    }
}