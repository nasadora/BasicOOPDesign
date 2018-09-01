using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOPDesign
{
    public class Student
    {
        private int studentID;
        public string firstname;
        public string lastname;
        private byte age;

        /// <summary>
        /// Set student names
        /// </summary>
        /// <param name="fn">firstname</param>
        /// <param name="ln">lastname</param>
        public void setNameInfo(string fn, string ln)
        {
            this.firstname = fn;
            this.lastname = ln;
        }

        public void setNameInfoWithAge(string fn, string ln, byte newAge)
        {
            this.firstname = fn;
            this.lastname = ln;
            this.age = newAge;
        }

        public string Country { get; set; }

        private string idNumber; // this field store value
        public string IdNumber
        {
            get { return idNumber; }    // get method
            set { idNumber = value; }   // set method
        }

        public byte Age
        {
            internal get { return this.age; }
            set {
                if (value < 18) throw new ApplicationException("Age connont under 18 years old.");
                this.age = value;
            }
        }

        // Read-Only Property
        public int StudentID {
            get { return this.studentID; }
        }
    }
}
