
namespace OOP_Intro
{
    internal class StudentData
    {
        //Private member fields 
        private string _name;
        private int _grade;

        //public Accessors & Mutators
        public string Name
        {
            get { return _name; }
            set
            {
                if(value.Length > 0)
                {
                    _name = value;
                }
                else
                {
                    throw new Exception("Invalid");
                }
            }
        }//end of Name

        public int Grade
        {
            get { return _grade; }
            set
            {
                if(value >= 0 && value <= 100)
                {
                    _grade = value;
                }
                else
                {
                    throw new Exception("Invalid grade");
                }
            }
        }//end of Grade

        //Constructor(s)
        public StudentData() //Empty constructor 
        {
            {
                Name = "John Doe";
                Grade = 25;
            }
        }

        public StudentData(string name, int grade)//Greedy constructor
        {
            Name = name;
            Grade = grade;
        }

        public override string ToString()
        {
            return $"Name: {Name}\tGrade: {Grade}";
        }
    }
}
