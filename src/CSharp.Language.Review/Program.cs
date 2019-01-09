//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp.Language.Review
//{
//    public class Program
//    {
//        private static Random rnd = new Random();

//        public static void Main(string[] args)
//        {
//            Program app = new Program(args);

//            app.AssignMarks(30, 80);

//            foreach (Student person in app.Students)
//            {
//                System.Console.WriteLine("Name: " + person.Name);
//                foreach (EarnedMark item in person.Marks)
//                    System.Console.WriteLine("\t" + item);
//            }
//        }

//        private List<Student> _students = new List<Student>();

//        public List<Student> Students
//        {
//            get { return _students; }
//            set { _students = value; }
//        }

//        public Program(string[] studentNames)
//        {
//            WeightedMark[] CourseMarks = new WeightedMark[4];
//            CourseMarks[0] = new WeightedMark("Quiz 1", 20);
//            CourseMarks[1] = new WeightedMark("Quiz 2", 20);
//            CourseMarks[2] = new WeightedMark("Exercies", 25);
//            CourseMarks[3] = new WeightedMark("Lab", 35);
//            int[] possibleMarks = new int[4] { 25, 50, 12, 35 };

//            foreach (string name in studentNames)
//            {
//                EarnedMark[] marks = new EarnedMark[4];
//                for (int i = 0; i < possibleMarks.Length; i++)
//                    marks[i] = new EarnedMark(CourseMarks[i], possibleMarks[i], 0);
//                Students.Add(new Student(name, marks));

//            }
//        }

//        public void AssignMarks(int min, int max)
//        {
//            foreach (Student person in Students)
//                foreach (EarnedMark item in person.Marks)
//                    item.Earned = (rnd.Next(min, max) / 100.0) * item.Possible;
//        }
//    }
//}
