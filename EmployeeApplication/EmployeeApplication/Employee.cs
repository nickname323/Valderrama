using System;

namespace EmployeeNamespace
{
    public class Employee
    {
        private int id;
        private string firstName;
        private string lastName;
        private string position;

        
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

       
        public Employee()
        {
        }

        
        public Employee(int id, string firstName, string lastName, string position)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.position = position;
        }

        
        public Employee(int id, string firstName)
        {
            this.id = id;
            this.firstName = firstName;
        }
    }
}