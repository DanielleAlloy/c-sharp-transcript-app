//******************************************************
// File: Student.cs
//
// Purpose: Contains the class definition for Student.
//          Student will hold all the student information 
//          such as the name of the student, the Id of 
//          the student, and the major of student.
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
    public class Student
    {
        #region StudentMemberVariables

        private string m_Name;
        private string m_Id;
        private string m_Major;

        #endregion

        #region StudentMethods
        
        //****************************************************
        // Method: Student
        //
        // Purpose: Default constructor for Student class
        //****************************************************
        public Student()
        {
            m_Name = "null";
            m_Id = "null";
            m_Major = "null";
        }
        
        //****************************************************
        // Method: ToString Override
        //
        // Purpose: Shows descriptive text and data for
        //          all member variables
        //****************************************************
        public override string ToString()
        {
            string aString;

            aString = m_Name;
            aString += ", ";
            aString += m_Id;
            aString += ", ";
            aString += m_Major;
            aString += ", ";
                
            return aString;
        }
       
        #endregion

        #region StudentProperties

        [DataMember(Name = "m_name")]
        // C# Property for m_Name
        public string Name
        {
            get { return m_Name; }
            set { m_Name = value; }
        }
        
        [DataMember(Name = "m_id")]
        //C# Property for m_Id
        public string Id
        {
            get { return m_Id; }
            set { m_Id = value; }
        }

        [DataMember(Name = "m_major")]
        //C# Property for m_Major
        public string Major
        {
            get { return m_Major; }
            set { m_Major = value; }
        }
      
        #endregion
        
    }
}