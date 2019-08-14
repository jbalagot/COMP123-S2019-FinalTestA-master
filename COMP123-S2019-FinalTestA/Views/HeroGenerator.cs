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

        public void LoadNames()
        {
            /// <summary>
            /// This method  loads the entire firstNames.txt and lastNames.txt file into FirstNameList and LastNameList lists
            /// </summary>
            public void LoadNames()
            {
                // textreader object to store the files
                TextReader firstNamesFile = new StreamReader("..\\..\\Data\\firstNames.txt");
                TextReader lastNamesFile = new StreamReader("..\\..\\Data\\lastNames.txt");

                // reads a line of characters from the text reader object
                string line = firstNamesFile.ReadLine();
                // loop that would read every line of the file and add each to the list
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
