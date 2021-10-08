using System;

namespace public_class
{    class User
    {
        public string StudentName;
        public string EnrollmentNo;
        public int Semester;
        public void GetUserDetails()
        {
            Console.WriteLine("Student Name: {0}", StudentName);
            Console.WriteLine("Enrollment No: {0}", EnrollmentNo);
            Console.WriteLine("Semester: {0}", Semester);
        }
    }
    class Program
    {
	//user class members are public so its members are accessible to all other classes
        static void Main(string[] args)
        {
            User u = new User();
            u.StudentName = "Smit Vora";
            u.EnrollmentNo = "180540107187";
            u.Semester = 7;
            u.GetUserDetails();

        }
	//Student Name: Smit Vora
	//Enrollment No: 180540107187
	//Semester: 7
    }
}
