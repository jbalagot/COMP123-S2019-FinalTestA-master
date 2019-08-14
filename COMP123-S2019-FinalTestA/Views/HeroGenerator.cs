using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;


/*
 * STUDENT NAME: JEANNERY MAE BALAGOT
 * STUDENT ID: 301051646
 * DESCRIPTION: This is the Hero Generator Form
 */

namespace COMP123_S2019_FinalTestA.Views
{
    public partial class HeroGenerator : COMP123_S2019_FinalTestA.Views.MasterForm
    {
        public List<string> FirstNameList = new List<string>();
        public List<string> LastNameList = new List<string>();

        // Random object that would generate a random number
        public Random random = new Random();

        public HeroGenerator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler for the BackButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        /// <summary>
        /// This method loads firstNames.txt and lastNames.txt file into FirstNameList and LastNameList lists
        /// </summary>
        public void LoadNames()
        {
     
         
                // textreader object to store the files
                TextReader firstNamesFile = new StreamReader("..\\..\\Data\\firstNames.txt");
                TextReader lastNamesFile = new StreamReader("..\\..\\Data\\lastNames.txt");

                // reads a line of characters from the text reader object
                string line = firstNamesFile.ReadLine();
                // loop that reads every line of the file and add to the list
                while (line != null)
                {
                    FirstNameList.Add(line);
                    line = firstNamesFile.ReadLine();
                }
                FirstNameList.Add(line);
                firstNamesFile.Close();


                line = lastNamesFile.ReadLine();
                while (line != null)
                {
                    LastNameList.Add(line);
                    line = lastNamesFile.ReadLine();
                }
                LastNameList.Add(line);
                lastNamesFile.Close();
            
        }

        /// <summary>
        ///  Method that will randomly pick First Names and Last Names from 
        ///  the FirstNameList and LastNameList controls and set the 
        ///  FirstNameDataLabel and LastNameDataLabel with these values 
        /// </summary>
        public void GenerateNames()
        {
            // gets the number of elements contained in the List
            int listCount = FirstNameList.Count;
            FirstNameDataLabel.Text = FirstNameList[random.Next(0, (listCount - 1))];

            listCount = LastNameList.Count;
            string lname = LastNameList[random.Next(0, (listCount - 1))];
            LastNameDataLabel.Text = lname;
        }
        /// <summary>
        /// Call the LoadNames method and call the GenerateNames method upon Form load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CharacterGeneratorForm_Load(object sender, EventArgs e)
        {
            LoadNames();
            GenerateNames();
            
        }

        /// <summary>
        /// Click Event that calls the GenerateNames method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateNameButton_Click(object sender, EventArgs e)
        {
            GenerateNames();

           
            Program.character.FirstName = FirstNameLabel.Text;
            Program.character.LastName = LastNameLabel.Text;
        }

        /// <summary>
        /// Method that generate random numbers ranging from 10 to 50 for each Ability 
        /// (Fighting,  Agility,  Strength,  Endurance,  Reason, Intuition, Psyche and Popularity
        /// </summary>
        private void GenerateAbilities()
        {
            Program.character.Fighting = $"{random.Next(10, 50)}";
            Program.character.Agility = $"{random.Next(10, 50)}";
            Program.character.Strength = $"{random.Next(10, 50)}";
            Program.character.Endurance = $"{random.Next(10, 50)}";
            Program.character.Reason = $"{random.Next(10, 50)}";
            Program.character.Intuition = $"{random.Next(10, 50)}";
            Program.character.Psyche = $"{random.Next(10, 50)}";
            Program.character.Popularity = $"{random.Next(10, 50)}";
        }
    
    private void BackButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex != 0)
            {
                MainTabControl.SelectedIndex--;
            }
        }

        /// <summary>
        /// This is the event handler for the NextButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedIndex < MainTabControl.TabPages.Count - 1)
            {
                MainTabControl.SelectedIndex++;
            }
        }

        
    }
}
