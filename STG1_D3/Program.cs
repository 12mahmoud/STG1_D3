using System.Net;

namespace STG1_D3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            #region read from user one employee
            employee = read();
            employee.PrintOneConsole();
            #endregion
            Console.WriteLine("-----------------------------------------------------------------------------");

            #region Array of employees
            Console.WriteLine("Enter number of employees");
            int size = int.Parse(Console.ReadLine());
            Employee[] employees = new Employee[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter employee{i+1} data");
                employees[i] = read();
            }
            for (int i = 0; i < size; i++)
            {

                Console.WriteLine($" Employee{i+1} information");
                Console.WriteLine(employees[i].PrintAsString());
            }

            #endregion

        }
        struct Employee
        {
            #region private variables
            int ssn;
            string fname;
            string lname;
            int age;
            string address;
            #endregion
            #region Setters 
            public void setSsn(int _ssn)
            {
                ssn = _ssn;
            }
            public void setFname(string _fname)
            {
                fname = _fname;

            }
            public void setLname(string _lname)
            {
               lname = _lname;
            }
            public void setAge(int _age)
            {
                
                if (_age < 23 || _age > 45)
                    throw new Exception("Age should be between 23 and 45 ");
                else
                    age = _age;
            }
           public void setAddress(string _address)
            {

                if (_address == "cairo" || _address == "giza" || _address == "alex")
                    address = _address;
                else
                    throw new Exception("Invalid address ");

            }
            #endregion
            #region Getters
            public int getSsn() { return ssn; }
            public string getFname() { return fname; }
            public string getLname() { return lname;}
            public int getAge() { return age;}
            public string getAddress() { return address;}
            #endregion
            public void PrintOneConsole()
            {
                Console.WriteLine($"Employee id is {this.ssn},\n"+
                    $"Employee fist name is {this.fname}\n"+
                    $"Employee last name is {this.lname}\n" +
                    $"Employee age is {this.age}\n" +
                    $"Employee address is {this.address}\n");
            }
            public string PrintAsString()
            {
                return $"Employee id is {this.ssn},\n" +
                    $"Employee fist name is {this.fname}\n" +
                    $"Employee last name is {this.lname}\n" +
                    $"Employee age is {this.age}\n" +
                    $"Employee address is {this.address}\n";
            }
        }
        static Employee read() {
            Employee employee= new Employee();
            Console.WriteLine("Enter Employee national id");
            employee.setSsn(int.Parse(Console.ReadLine()));
            Console.WriteLine("Enter Employee first name");
            employee.setFname(Console.ReadLine());
            Console.WriteLine("Enter Employee Last name");
            employee.setLname(Console.ReadLine());
            do
            {
                try
                {
                    Console.WriteLine("Enter Employee age");
                    employee.setAge(int.Parse(Console.ReadLine()));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while (employee.getAge() < 23 || employee.getAge() > 45);

            do
            {
                try
                {
                    Console.WriteLine("Enter Employee address");
                    employee.setAddress(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (employee.getAddress() != "cairo" && employee.getAddress() != "giza" && employee.getAddress() != "alex");
            return employee;
        }

    }
}
