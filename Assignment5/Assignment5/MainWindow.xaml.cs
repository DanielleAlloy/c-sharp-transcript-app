using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Runtime.Serialization.Json;
using System.Data.SqlClient;

namespace Assignment5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string filename;
        public FileStream reader;
        DataContractJsonSerializer inputSerializer;

        List<Transcript.Transcript> tList = new List<Transcript.Transcript>();

        string connString = @"server=(LocalDB)\MSSQLLocalDB;" +
			"integrated security = SSPI;" +
			"database=Transcript;" +
			"MultipleActiveResultSets=True";

        SqlConnection sqlConn;



        public MainWindow()
        {
            InitializeComponent();
        }
        //**************************************************************
        // Method:  Window_Loaded(object sender, RoutedEventArgs e)
        //
        // Purpose: Event Handler: When the window is loading it should 
        //          populate the transcript ListBox with data from the 
        //          SQL Server database
        //**************************************************************
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Setup the SELECT SQL command
            string sql = "SELECT * FROM Transcript";
            sqlConn = new SqlConnection(connString);

            SqlCommand command = new SqlCommand(sql, sqlConn);

            // Open the connection
            sqlConn.Open();

            // Retrieve the data from the database
            SqlDataReader reader = command.ExecuteReader();

            //Clears any existing data in the ListBox
            TranscriptsListBox.Items.Clear();

            while (reader.Read())
            {
                TranscriptsListBox.Items.Add(reader["Name"]);
            }
        }
        //**************************************************************
        // Method:  MenuItem_Click(object sender, RoutedEventArgs e)
        //
        // Purpose: Event Handler for the Import->Transcript from JSON 
        //          MenuItem: Opens the JSON file and serializes it into 
        //          a instance of a List of Transcript; clears the 
        //          exisiting data in database; and populates Transcript 
        //          database with data from Transcript List
        //**************************************************************
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            //Sets the Title of the OpenFileDialog Window
            open.Title = "Open Transcript from JSON";
            //Sets the appPath as the current working directory
            string appPath = System.IO.Path.GetFullPath(".");

            //Sets the initial Directory as the appPath
            open.InitialDirectory = appPath;
            //Filters the files to show only JSON files 
            //open.DefaultExt = "json";
            open.Filter = "JSON files (*.json)|*.json";

            open.ShowDialog();

            //Reads in the filename from the OpenFileDialog
            filename = open.FileName;

            //if the filename is not blank - Error Handling - allows user to press cancel 
            if (filename != "")
            {
                //opens the file
                reader = new FileStream(filename, FileMode.Open, FileAccess.Read);

                //Serialization
                inputSerializer = new DataContractJsonSerializer(typeof(List<Transcript.Transcript>));

                //Reads the file into the tList
                tList = (List<Transcript.Transcript>)inputSerializer.ReadObject(reader);
                reader.Close();

                sqlConn = new SqlConnection(connString);

                // Open the connection
                sqlConn.Open();

                //****************************************************
                // Deletes the previous data from the Transcript Table
                //****************************************************
                // Setup the DELETE SQL command
                string sql = "DELETE FROM Transcript";

                SqlCommand command = new SqlCommand(sql, sqlConn);
                //Executes the DELETE command
                int rowsAffected = command.ExecuteNonQuery();

                TranscriptsListBox.Items.Clear();

                //Loops through the List<Transcript>
                for (int i=0; i < tList.Count; i++)
                {
                    string id = tList[i].Student.Id;
                    string name = tList[i].Student.Name;
                    string major = tList[i].Student.Major;

                    // Setup the INSERT SQL command
                    sql = "INSERT INTO Transcript" +
                            "(Name, Id, Major) Values" +
                            "(@name, @id, @major)";

                    command = new SqlCommand(sql, sqlConn);

                    command.Parameters.Add(new SqlParameter("@name", name));
                    command.Parameters.Add(new SqlParameter("@id", id));
                    command.Parameters.Add(new SqlParameter("@major", major));

                    //Executes the INSERT command
                    rowsAffected = command.ExecuteNonQuery();

                    TranscriptsListBox.Items.Add(name);
                }
            }
        }
        //**************************************************************
        // Method:  MenuItem_Click_1(object sender, RoutedEventArgs e)
        //
        // Purpose: Event Handler for the File->Exit MenuItem:
        //          Exits the application 
        //**************************************************************
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
        //**************************************************************
        // Method: MenuItem_Click_2(object sender, RoutedEventArgs e)
        //
        // Purpose: Event Handler for the Help->About MenuItem:
        //          Displays hould show a dialog box that displays the 
        //          program name, program version, and developer name.
        //**************************************************************
        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            string messageBoxText = "Transcript GUI \n" +
                "Version 2.0\n" +
                "Written by Danielle Hyland";
            string caption = "About Transcript GUI";
            MessageBoxButton button = MessageBoxButton.OK;

            // Display message box
            MessageBox.Show(messageBoxText, caption, button);

        }
        //****************************************************************************************
        // Method: TranscriptsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //
        // Purpose: ListBox Event Handling: When a transcript name is selected in the transcript 
        //          name ListBox the appropriate data should be displayed on the right side of the 
        //          window in the ID, Name and Major TextBoxes.That means the TextBoxes must be 
        //          populated with the appropriate data for the selected ListBox item from database.
        //****************************************************************************************
        private void TranscriptsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems != null && e.AddedItems.Count > 0)
            {
                string target = e.AddedItems[0].ToString();

                //Setup the SELECT SQL command
                string sql = "SELECT * FROM Transcript";
                sqlConn = new SqlConnection(connString);

                SqlCommand command = new SqlCommand(sql, sqlConn);

                // Open the connection
                sqlConn.Open();

                // Retrieve the data from the database
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if ((string)reader["Name"] == target)
                    {
                        IDTextBox.Text = (string)reader["Id"];
                        NameTextBox.Text = (string)reader["Name"];
                        MajorTextBox.Text = (string)reader["Major"];
                    }

                }
            }
            
        }

    }
}
