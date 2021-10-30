using System;

namespace inheritance{
    class Company
    {
        int CompanyCode;
        string CompanyName, ComapnySector;
        //method to get company data
        public void GetCompanyData()
        {
            Console.WriteLine("ENTER COMPANY DETAILS:");
            Console.WriteLine("ENTER COMPANY CODE");
            CompanyCode = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER COMPANY NAME");
            CompanyName = Console.ReadLine();
            Console.WriteLine("ENTER COMPANY SECTOR");
            ComapnySector = Console.ReadLine();
        }
        //method to show company data
        public void DisplayCompanyData()
        {
            Console.WriteLine("COMPANY CODE IS : " + CompanyCode);
            Console.WriteLine("COMPANY NAME IS : " + CompanyName);
            Console.WriteLine("COMPANY SECTOR IS : " + ComapnySector);
        }
    }
    //Employee class inherits company class and all it's properties
    class Employee : Company
    {
        int EmployeeId, EmployeeAge;
        string EmployeeName, EmployeeAddress;
        //method to get employee data
        public void GetEmployeeData()
        {
            Console.WriteLine("ENTER EMPLOYEE DETAILS:");
            Console.WriteLine("ENTER EMPLOYEE ID");
            EmployeeId = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER EMPLOYEE AGE");
            EmployeeAge = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER EMPLOYEE NAME");
            EmployeeName = Console.ReadLine();
            Console.WriteLine("ENTER EMPLOYEE ADDRESS");
            EmployeeAddress = Console.ReadLine();
        }
        //method to show employee data
        public void DisplayEmployeeData()
        {
            Console.WriteLine("EMPLOYEE ID IS : " + EmployeeId);
            Console.WriteLine("EMPLOYEE NAME IS : " + EmployeeName);
            Console.WriteLine("EMPLOYEE ADDRESS IS : " + EmployeeAddress);
            Console.WriteLine("EMPLOYEE AGE IS : " + EmployeeAge);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee objEmployee = new Employee();
            objEmployee.GetCompanyData();
            //ENTER COMPANY DETAILS:
            //ENTER COMPANY CODE
            //101
            //ENTER COMPANY NAME
            //VorCorp.
            //ENTER COMPANY SECTOR
            //FinTech

            objEmployee.GetEmployeeData();
            //ENTER EMPLOYEE DETAILS:
            //ENTER EMPLOYEE ID
            //205
            //ENTER EMPLOYEE AGE
            //22
            //ENTER EMPLOYEE NAME
            //Jenil
            //ENTER EMPLOYEE ADDRESS
            //Rajkot

            objEmployee.DisplayCompanyData();
            //output - 
            //COMPANY CODE IS: 101
            //COMPANY NAME IS: VorCorp.
            //COMPANY SECTOR IS: FinTech

            objEmployee.DisplayEmployeeData();
            //output-
            //EMPLOYEE ID IS: 205
            //EMPLOYEE NAME IS: Jenil
            //EMPLOYEE ADDRESS IS : Rajkot
            //EMPLOYEE AGE IS : 22

        }
    }
}
