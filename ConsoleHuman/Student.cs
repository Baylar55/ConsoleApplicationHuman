namespace ConsoleHuman
{
    class Student : Human
    {
        public int Grade { get; set; }

        public Student()
        {
            
        }

        public Student(string stname, string stsurname, int stage,int grade):base(stname,stsurname, stage)
        {
            Grade = grade;
        }

    }
}
