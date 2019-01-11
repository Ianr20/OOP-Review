//identifiest the namespaces contianing the data types
// that we want to use or reference in thoe code i n this file.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// decleares an area or named space in which we can place our program or defined data types.
namespace CSharp.Language.Review
{

    //the namespace plus the class names is whats called the "fully-quallified" class name.
    // the fully qualified class name for the program is 
    // CSHarp.Language,Review.Program
    public class Program
    {

        // a static field initialized to a new random object
        private static Random rnd = new Random();

        //main() us the enry point
        //the body of the main method acts as a driver of the application
        // as soon as you exit the main you stop
        public static void Main(string[] args)
        {
            Program app = new Program(args);

            app.AssignMarks(30, 80);

            foreach (Student person in app.Students)
            {
                System.Console.WriteLine("Name: " + person.Name);
                foreach (EarnedMark item in person.Marks)
                    System.Console.WriteLine("\t" + item);
            }
        }

       //this field is acting as a backing store for the students property
       // provides controlled accest to the data in the backing store

        
        private List<Student> _students = new List<Student>();

        public List<Student> Students
        {
            get { return _students; }
            set { _students = value; }
        }

        //this is a constructor
        // the job of a constructor is to snsure
        // that all of the fields or properties 
       // have meaningful values
        public Program(string[] studentNames)
        {
            WeightedMark[] CourseMarks = new WeightedMark[4];
            CourseMarks[0] = new WeightedMark("Quiz 1", 20);
            CourseMarks[1] = new WeightedMark("Quiz 2", 20);
            CourseMarks[2] = new WeightedMark("Exercies", 25);
            CourseMarks[3] = new WeightedMark("Lab", 35);
            int[] possibleMarks = new int[4] { 25, 50, 12, 35 };

            foreach (string name in studentNames)
            {
                EarnedMark[] marks = new EarnedMark[4];
                for (int i = 0; i < possibleMarks.Length; i++)
                    marks[i] = new EarnedMark(CourseMarks[i], possibleMarks[i], 0);
                Students.Add(new Student(name, marks));

            }
        }
        /// <summary>
        /// assings a random mark to each student 
        /// in the <see cref="Students"/> property.
        /// </summary>
        /// <param name="min"> min grade </param>
        /// <param name="max"> max grade </param>
        public void AssignMarks(int min, int max)
        {
            foreach (Student person in Students)
                foreach (EarnedMark item in person.Marks)
                    item.Earned = (rnd.Next(min, max) / 100.0) * item.Possible;
        }
    }
}

// a class is a blueprint for generating objects. the class describes 
//1) what the object looks like 
//2) how the object behaves


    //acessModifier class className
    //{
    //Fields
    //Properties
    //constructors
    //methods
    //}