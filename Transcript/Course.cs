//******************************************************
// File: Course.cs
//
// Purpose: Contains the class definition for Course.
//          Course will hold all course information 
//          such as the subject of course, course
//          number, course title, course description,
//          and the number of credits of the course.
//          It contains an override of toString,
//          which returns a string containing all the 
//          member variables with descriptive text.
//          This class was built to be used in the
//          MainProgram and TranscriptUnitTesting.
//
// Written By: Danielle Hyland
//
// Compiler: JetBrains Rider
//
//******************************************************


using System.Runtime.Serialization;

namespace Transcript
{
    [DataContract]
    public class Course
    {
        #region CourseMemberVariables

        private string m_Subject;
        private string m_Number;
        private string m_Title;
        private string m_Description;
        private int m_Credits;

        #endregion

        #region CourseMethods
        
        //****************************************************
        // Method: Course
        //
        // Purpose: Default constructor for the Course class
        //****************************************************
        public Course()
        {
            m_Subject = "null";
            m_Number = "null";
            m_Title = "null";
            m_Description = "null";
            m_Credits = 0;
        }
        
        //****************************************************
        // Method: ToString Override
        //
        // Purpose: Shows descriptive text and data for
        //          all member variables
        //****************************************************
        public override string ToString()
        {
            //String to  hold the toString data
            string aString;

            aString = m_Subject;
            aString += ", ";
            aString += m_Number;
            aString += ", ";
            aString += m_Title;
            aString += ", ";
            aString += m_Description;
            aString += ", ";
            aString += m_Credits;
            aString += ", ";

            return aString;
        }

        #endregion
        
        #region CourseProperties
        
        [DataMember(Name = "m_subject")]
        //C# Property for m_Subject
        public string Subject
        {
            get { return m_Subject; }
            set { m_Subject = value; }
        }
        
        [DataMember(Name = "m_number")]
        //C# Property for m_Number
        public string Number
        {
            get { return m_Number; }
            set { m_Number = value; }
        }

        [DataMember(Name = "m_title")]
        //C# Property for m_Title
        public string Title
        {
            get { return m_Title; }
            set { m_Title = value; }
        }
        
        [DataMember(Name="m_description")]
        //C# Property for m_Description
        public string Description
        {
            get { return m_Description; }
            set { m_Description = value; }
        }
        
        [DataMember(Name = "m_credits")]
        //C# Property for m_Credits
        public int Credits
        {
            get { return m_Credits; }
            set { m_Credits = value; }
        }

        #endregion 
        
    }
}