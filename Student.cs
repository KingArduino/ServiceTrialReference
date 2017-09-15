using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS
{
    public class Student : Person
    {
        public string Major { get; protected set; }
        public string Degree { get; protected set; }
        public Transcript Transcript { get; protected set;}

        public Student(string name, string id, string major, string degree) : base(name, id) 
        {
            Major = major;
            Degree = degree;
            Transcript = new Transcript(this);

            attends = new List<Section>();
        }

        public Student(string name, string id) : this(name, id, "TBD","TBD")
        {

        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Student-Specific Information:");
            Console.WriteLine("\tMajor: " + Major);
            Console.WriteLine("\tDegree: " + Degree);
            DisplayCourseSchedule();
            Transcript.Display();
        }
        
        
   
        public List<Section> Attends;
        {
            get {
                return attends;
                }
            set {
                attends = value;
                }
            }
        
        public override string ToString()
        {
            return name + " (" + Id + ") " " + [" + Degree + " - " + Major + "]";
        }

        public void AddSection(Section s)
        {
            attends.Add(s);
        }
        
    }
}
