namespace StudentInfoApplication
{
    public class StudentInfo
    {
        private string studentID;
        private string firstName;
        private string lastName;

        
        public StudentInfo() { }

        
        public StudentInfo(string id, string fname, string lname)
        {
            studentID = id;
            firstName = fname;
            lastName = lname;
        }

        
        public string StudentID
        {
            get { return studentID; }
            set { studentID = value; }
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
    }
}