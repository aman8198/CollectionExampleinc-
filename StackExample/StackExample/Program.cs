namespace StackExample
{
    class Student
    {
        public int Marks { get; set; }
        public int Rank { get; set; }
    }
    class Program
    {
        static void Main()
        {
            //create object of stack
            //stack follows LIFO
            Stack<Student> student = new Stack<Student>();

            //Add
            student.Push(new Student() { Marks = 45 });
            student.Push(new Student() { Marks = 61 });
            student.Push(new Student() { Marks = 80 });

            //foreach to print elements in stack
            int r = 1;
            foreach(Student item in student)
            {
                item.Rank = r;
                Console.WriteLine(item.Marks + ", " + item.Rank);
                r++;
            }

            //pop
            student.Pop();

            //peek
            student.Peek();

            //Count 
            student.Count();

            //Contains
            student.Contains(new Student() { Marks = 45 });

            //Convert to array
            student.ToArray();

            //Remove all elements
            student.Clear();

            //no index based element location
            Console.ReadLine();
        }
    }
}