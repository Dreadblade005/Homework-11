using System;
using System.Collections;
using System.Text;

namespace part1
{
   public class Student
    {
        private string Fname;
        private string Lname;
        public int score; 

        public Student(string fname, string lname, int score)
        {
            Fname = fname;
            Lname = lname;
            this.score = score;
        }
        public void SetFName(string fname)
        {
            Fname = fname;
        }
        public void SetLname(string lname)
        {
            Lname = lname;
        }
        public void SetFullName(string fname, string lname)
        {
            Fname = fname;
            Lname = lname;
        }
        public void setScore(int score)
        {
            this.score = score;
        }
        public string GetFname()
        {
            return Fname;
        }
        public string GetLname()
        {
            return Lname;
        }
        public int GetScore()
        {
            return score;
        }
        public CompareStudent(object individual)
        {
            if (individual == null) return 1;

            Student otherstudent = individual as Student;
            if (otherstudent != null)
            {
                return this.score.CompareTo(otherstudent.score);
            }
            else
            {
                throw new ArgumentException("Object is not a student");
            }
        }
       

        }


    }

