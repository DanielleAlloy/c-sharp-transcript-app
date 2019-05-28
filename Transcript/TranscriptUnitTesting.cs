//******************************************************************
// File: TranscriptUnitTesting.cs
//
// Purpose: Contains the class definition for TranscriptUnitTesting.
//          TranscriptUnitTesting perform unit testing for the 
//          Student and Course classes. Tests that the properties 
//          are set correctly, and will display a pass or fail 
//          message to the user. Will be used in the console menu
//          in the MainProgram.
//
// Written By: Danielle Hyland
//
// Compiler: JetBrains Rider
//
//******************************************************************
namespace Transcript
{
    public class TranscriptUnitTesting
    {
        #region TranscriptUnitTestingMethods
        
        //****************************************************
        // Method: UnitTestCourse
        //
        // Purpose: To declare an instance of Course and 
        //          perform unit testing on all the properties
        //          of that instance. It will cause pass/fail
        //          messages to appear on screen for each unit
        //          test.
        //**************************************************** 
        public void UnitTestCourse()
        {
            Course testCourse = new Course();
            
            //Test Variables
            string testTitle = "C# Programming";
            string  testSubject = "Programming";
            string testNumber = "BCS426";
            string testDescription = "Learn the basics of C# programming";
            int testCredits = 3;
           
            //Sets the variables
            testCourse.Title = testTitle;
            testCourse.Subject = testSubject;
            testCourse.Number = testNumber;
            testCourse.Description = testDescription;
            testCourse.Credits = testCredits;
            
            //Unit Testing Code for Title
            if (testCourse.Title == testTitle)
            {
                System.Console.WriteLine("Title Property: Pass");
            }
            else
            {
                System.Console.WriteLine("Title Property: Fail!");
            }
            
            //Unit Testing Code for Subject
            if (testCourse.Subject == testSubject)
            {
                System.Console.WriteLine("Subject Property: Pass");
            }
            else
            {
                System.Console.WriteLine("Subject Property: Fail!");
            }
            
            //Unit Testing Code for Number
            if (testCourse.Number == testNumber)
            {
                System.Console.WriteLine("Number Property: Pass");
            }
            else
            {
                System.Console.WriteLine("Number Property: Fail!");
            }
            
            //Unit Testing Code for Description
            if (testCourse.Description == testDescription)
            {
                System.Console.WriteLine("Title Property: Pass");
            }
            else
            {
                System.Console.WriteLine("Title Property: Fail!");
            }
            
            //Unit Testing Code for Credits
            if (testCredits == testCourse.Credits)
            {
                System.Console.WriteLine("Credits Property: Pass");
            }
            else
            {
                System.Console.WriteLine("Credits Property: Fail!");
            }
        }

        //****************************************************
        // Method: UnitTestStudent
        //
        // Purpose: To declare an instance of Student and 
        //          perform unit testing on all the properties
        //          of that instance. It will cause pass/fail
        //          messages to appear on screen for each unit
        //          test.
        //**************************************************** 
        public void UnitTestStudent()
        {
            Student testStudent = new Student();
            
            //Testing Variables
            string testName = "TestName";
            string testId = "TestId";
            string testMajor = "TestMajor";

            //Sets the test variables
            testStudent.Name = testName;
            testStudent.Id = testId;
            testStudent.Major = testMajor;

            //Unit Testing Code for Name
            if (testStudent.Name == testName)
            {
                System.Console.WriteLine("Name Properties Pass");
            }
            else
            {
                System.Console.WriteLine("Name Properties Fail!");
            }
            
            //Unit Testing Code for id
            if (testStudent.Id == testId)
            {
                System.Console.WriteLine("Title Properties Pass");
            }
            else
            {
                System.Console.WriteLine("Title Properties Fail!");
            }
            
            //Unit Testing Code for major
            if (testStudent.Major == testMajor)
            {
                System.Console.WriteLine("Title Properties Pass");
            }
            else
            {
                System.Console.WriteLine("Title Properties Fail!");
            }
        }

        

        #endregion
        
    }
}