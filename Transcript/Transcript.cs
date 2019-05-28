//******************************************************
// File: Transcript.cs
//
// Purpose: Contains the class definition for Transcript.
//          Transcript member variables will hold an
//          instance of Student and a List of Courses.
//          It contains an override of toString,
//          which returns a string containing all the 
//          member variables with descriptive text.
//          This class was built to be used in the
//          MainProject (Program.cs).
//
// Written By: Danielle Hyland
//
// Compiler: JetBrains Rider
//
//******************************************************
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Transcript
{
    [DataContract]
    public class Transcript
    {
        #region TranscriptMemberVariables

        private Student m_Student;
        private List<Course> m_Courses;

        #endregion
        
        #region TranscriptProperties
        
        [DataMember(Name = "m_student")]
        //C# Property for m_Student
        public Student Student       
        {
            get { return m_Student; }
            set { m_Student = value; }
        }

        [DataMember(Name = "m_courses")]
        //C# Property for m_Courses
        public List<Course> Courses
        {
            get { return m_Courses; }
            set { m_Courses = value; }
        }
        

        #endregion

        #region TranscriptMethods
        
        //****************************************************
        // Method: Transcript
        //
        // Purpose: Default constructor for the Transcript class
        //****************************************************
        public Transcript()
        {
            m_Student = new Student(); 
            m_Courses = new List<Course>();
        }
        
        
        //****************************************************
        // Method: ToString Override
        //
        // Purpose: Shows descriptive text and data for
        //          all member variables of Transcript class
        //****************************************************
        public override string ToString()
        {
            String s = "";

            s += m_Student.ToString();
            //Loops through the Course List to get all Courses
            foreach (Course c in m_Courses)
            {
                s += c.ToString();
            }
            

            return s;
        }

        #endregion

    }
}