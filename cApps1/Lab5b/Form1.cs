/*
    Author: Michael Laking
    ID:     00775971
    Date:   December, 2018

    Purpose: The program has multiple methods including which work together to provide the
             user with a functional UI. The user may select a .txt file to be read which is
             put through the Read() method which creates unique objects for each identified
             type and appends them to a list. LINQ is utilized to join together the lists allowing
             for proper identification of similar Docotrs to Companions to Episodes.

*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5b
{
    public partial class Form1 : Form
    {
        private string fileName;
        List<Doctor> doctorList = new List<Doctor>();
        List<Companion> companionList = new List<Companion>();
        List<Episode> episodeList = new List<Episode>();


        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The purpose of this method is to provide a window for the user to select a .txt file when
        /// the Open Menu Item is clicked. It only allows for .txt files to be selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Please select a TXT File";
            openFileDialog.Filter = "Text|*.txt";

            if ( openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
                Read();
            }

            doctorList.Sort((x, y) => int.Parse(x.Ordinal).CompareTo(int.Parse(y.Ordinal)));

            foreach ( Doctor c in doctorList )
            {
                doctorComboBox.Items.Add(c.Ordinal);
            }

            doctorComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// The Read method analyzes the .txt file and skims for "C", "D", or "E" which determines
        /// which type of object to create and append to a list accordingly
        /// </summary>
        private void Read()
        {
            StreamReader myReader = new StreamReader(fileName);

            while (!myReader.EndOfStream)
            {

                List<string[]> myList = new List<string[]>
                {
                    myReader.ReadLine().Split('|')
                };

                int count2 = 0;

                foreach ( string[] i in myList )
                {

                    if (i[0].TrimEnd() == "D")
                    {
                        Doctor tempDoctor = new Doctor(i[1].Trim().ToString(), i[2].Trim().ToString(), i[3].Trim().ToString(), i[4].Trim().ToString(), i[5].Trim().ToString());
                        doctorList.Add(tempDoctor);

                    }
                    else if (i[0].TrimEnd() == "C")
                    {
                        Companion tempCompanion = new Companion(i[1].Trim().ToString(), i[2].Trim().ToString(), i[3].Trim().ToString(), i[4].Trim().ToString());
                        companionList.Add(tempCompanion);


                    }
                    else if (i[0].TrimEnd() == "E")
                    {
                        Episode tempEpisode = new Episode(i[1].Trim().ToString(), i[2].Trim().ToString(), i[3].Trim().ToString(), i[4].Trim().ToString());
                        episodeList.Add(tempEpisode);

                    }
                    count2++;
                }

            }

        }

        /// <summary>
        /// This method's purpose is to Exit the application when the Exit Menu Item is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// The purpose of this method is to make use of LINQ to join all three lists by the Debut and Story attributes.
        /// Three Foreach loops are used to cycle through the information now joined together and is assigned to the correct
        /// Textbox determined by which Combobox Item is selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void doctorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            episodeListText.Clear();

            
            var episodes =
                from myEpisodes in episodeList
                orderby myEpisodes.Story
                join myDoctors in doctorList
                    on myEpisodes.Story equals myDoctors.Debut
                    into docs
                join myCompanions in companionList
                    on myEpisodes.Story equals myCompanions.Debut
                    into comps
                select new
                {
                    Episode = myEpisodes,
                    Companions = comps.ToList(),
                    Doctors = docs.ToList()
                };

            foreach (var episode in episodes)
            {

                foreach (var doc in episode.Doctors)
                {
                    if ( ( doc.Ordinal == "1" ) && ( doctorComboBox.SelectedItem.ToString() == "1" ) )
                    {
                        actorText.Text = doc.Actor;
                        ageText.Text = doc.Age;
                        yearText.Text = episode.Episode.Year;
                        seriesText.Text = doc.Series;
                        episodeText.Text = episode.Episode.Title;
                    }
                    else if ((doc.Ordinal == "2") && (doctorComboBox.SelectedItem.ToString() == "2"))
                    {
                        actorText.Text = doc.Actor;
                        ageText.Text = doc.Age;
                        yearText.Text = episode.Episode.Year;
                        seriesText.Text = doc.Series;
                        episodeText.Text = episode.Episode.Title;
                        
                    }
                    else if ((doc.Ordinal == "3") && (doctorComboBox.SelectedItem.ToString() == "3"))
                    {
                        actorText.Text = doc.Actor;
                        ageText.Text = doc.Age;
                        yearText.Text = episode.Episode.Year;
                        seriesText.Text = doc.Series;
                        episodeText.Text = episode.Episode.Title;

                    }
                    else if ((doc.Ordinal == "4") && (doctorComboBox.SelectedItem.ToString() == "4"))
                    {
                        actorText.Text = doc.Actor;
                        ageText.Text = doc.Age;
                        yearText.Text = episode.Episode.Year;
                        seriesText.Text = doc.Series;
                        episodeText.Text = episode.Episode.Title;

                    }
                    else if ((doc.Ordinal == "5") && (doctorComboBox.SelectedItem.ToString() == "5"))
                    {
                        actorText.Text = doc.Actor;
                        ageText.Text = doc.Age;
                        yearText.Text = episode.Episode.Year;
                        seriesText.Text = doc.Series;
                        episodeText.Text = episode.Episode.Title;

                    }
                    else if ((doc.Ordinal == "6") && (doctorComboBox.SelectedItem.ToString() == "6"))
                    {
                        actorText.Text = doc.Actor;
                        ageText.Text = doc.Age;
                        yearText.Text = episode.Episode.Year;
                        seriesText.Text = doc.Series;
                        episodeText.Text = episode.Episode.Title;

                    }
                    else if ((doc.Ordinal == "7") && (doctorComboBox.SelectedItem.ToString() == "7"))
                    {
                        actorText.Text = doc.Actor;
                        ageText.Text = doc.Age;
                        yearText.Text = episode.Episode.Year;
                        seriesText.Text = doc.Series;
                        episodeText.Text = episode.Episode.Title;

                    }
                    else if ((doc.Ordinal == "8") && (doctorComboBox.SelectedItem.ToString() == "8"))
                    {
                        actorText.Text = doc.Actor;
                        ageText.Text = doc.Age;
                        yearText.Text = episode.Episode.Year;
                        seriesText.Text = doc.Series;
                        episodeText.Text = episode.Episode.Title;

                    }
                    else if ((doc.Ordinal == "9") && (doctorComboBox.SelectedItem.ToString() == "9"))
                    {
                        actorText.Text = doc.Actor;
                        ageText.Text = doc.Age;
                        yearText.Text = episode.Episode.Year;
                        seriesText.Text = doc.Series;
                        episodeText.Text = episode.Episode.Title;

                    }
                    else if ((doc.Ordinal == "10") && (doctorComboBox.SelectedItem.ToString() == "10"))
                    {
                        actorText.Text = doc.Actor;
                        ageText.Text = doc.Age;
                        yearText.Text = episode.Episode.Year;
                        seriesText.Text = doc.Series;
                        episodeText.Text = episode.Episode.Title;

                    }
                    else if ((doc.Ordinal == "11") && (doctorComboBox.SelectedItem.ToString() == "11"))
                    {
                        actorText.Text = doc.Actor;
                        ageText.Text = doc.Age;
                        yearText.Text = episode.Episode.Year;
                        seriesText.Text = doc.Series;
                        episodeText.Text = episode.Episode.Title;

                    }
                    else if ((doc.Ordinal == "12") && (doctorComboBox.SelectedItem.ToString() == "12"))
                    {
                        actorText.Text = doc.Actor;
                        ageText.Text = doc.Age;
                        yearText.Text = episode.Episode.Year;
                        seriesText.Text = doc.Series;
                        episodeText.Text = episode.Episode.Title;

                    }

                }
                foreach (var comps in episode.Companions)
                {
                    if ( ( comps.Doctor == "1" ) && (doctorComboBox.SelectedItem.ToString() == "1") )
                    {
                        episodeListText.AppendText(comps.Name + " (" + comps.Actor + ") " );
                        episodeListText.AppendText(Environment.NewLine);
                        episodeListText.AppendText( "\"" + episode.Episode.Title + "\n (" + episode.Episode.Year + ")" );
                        episodeListText.AppendText(Environment.NewLine);
                        episodeListText.AppendText(Environment.NewLine);
                    }

                    else if ((comps.Doctor == "2") && (doctorComboBox.SelectedItem.ToString() == "2"))
                    {
                        episodeListText.AppendText(comps.Name + " (" + comps.Actor + ") ");
                        episodeListText.AppendText(Environment.NewLine);
                        episodeListText.AppendText("\"" + episode.Episode.Title + "\n (" + episode.Episode.Year + ")");
                        episodeListText.AppendText(Environment.NewLine);
                        episodeListText.AppendText(Environment.NewLine);
                    }
                    else if ((comps.Doctor == "3") && (doctorComboBox.SelectedItem.ToString() == "3"))
                    {
                        episodeListText.AppendText(comps.Name + " (" + comps.Actor + ") ");
                        episodeListText.AppendText(Environment.NewLine);
                        episodeListText.AppendText("\"" + episode.Episode.Title + "\n (" + episode.Episode.Year + ")");
                        episodeListText.AppendText(Environment.NewLine);
                        episodeListText.AppendText(Environment.NewLine);
                    }
                    else if ((comps.Doctor == "4") && (doctorComboBox.SelectedItem.ToString() == "4"))
                    {
                        episodeListText.AppendText(comps.Name + " (" + comps.Actor + ") ");
                        episodeListText.AppendText(Environment.NewLine);
                        episodeListText.AppendText("\"" + episode.Episode.Title + "\n (" + episode.Episode.Year + ")");
                        episodeListText.AppendText(Environment.NewLine);
                        episodeListText.AppendText(Environment.NewLine);
                    }
                    else if ((comps.Doctor == "5") && (doctorComboBox.SelectedItem.ToString() == "5"))
                    {
                        episodeListText.AppendText(comps.Name + " (" + comps.Actor + ") ");
                        episodeListText.AppendText(Environment.NewLine);
                        episodeListText.AppendText("\"" + episode.Episode.Title + "\n (" + episode.Episode.Year + ")");
                        episodeListText.AppendText(Environment.NewLine);
                        episodeListText.AppendText(Environment.NewLine);
                    }
                    else if ((comps.Doctor == "6") && (doctorComboBox.SelectedItem.ToString() == "6"))
                    {
                        episodeListText.AppendText(comps.Name + " (" + comps.Actor + ") ");
                        episodeListText.AppendText(Environment.NewLine);
                        episodeListText.AppendText("\"" + episode.Episode.Title + "\n (" + episode.Episode.Year + ")");
                        episodeListText.AppendText(Environment.NewLine);
                        episodeListText.AppendText(Environment.NewLine);
                    }
                    else if ((comps.Doctor == "7") && (doctorComboBox.SelectedItem.ToString() == "7"))
                    {
                        episodeListText.AppendText(comps.Name + " (" + comps.Actor + ") ");
                        episodeListText.AppendText(Environment.NewLine);
                        episodeListText.AppendText("\"" + episode.Episode.Title + "\n (" + episode.Episode.Year + ")");
                        episodeListText.AppendText(Environment.NewLine);
                        episodeListText.AppendText(Environment.NewLine);
                    }
                    else if ((comps.Doctor == "8") && (doctorComboBox.SelectedItem.ToString() == "8"))
                    {
                        episodeListText.AppendText(comps.Name + " (" + comps.Actor + ") ");
                        episodeListText.AppendText(Environment.NewLine);
                        episodeListText.AppendText("\"" + episode.Episode.Title + "\n (" + episode.Episode.Year + ")");
                        episodeListText.AppendText(Environment.NewLine);
                        episodeListText.AppendText(Environment.NewLine);
                    }
                    else if ((comps.Doctor == "9") && (doctorComboBox.SelectedItem.ToString() == "9"))
                    {
                        episodeListText.AppendText(comps.Name + " (" + comps.Actor + ") ");
                        episodeListText.AppendText(Environment.NewLine);
                        episodeListText.AppendText("\"" + episode.Episode.Title + "\n (" + episode.Episode.Year + ")");
                        episodeListText.AppendText(Environment.NewLine);
                        episodeListText.AppendText(Environment.NewLine);
                    }
                    else if ((comps.Doctor == "10") && (doctorComboBox.SelectedItem.ToString() == "10"))
                    {
                        episodeListText.AppendText(comps.Name + " (" + comps.Actor + ") ");
                        episodeListText.AppendText(Environment.NewLine);
                        episodeListText.AppendText("\"" + episode.Episode.Title + "\n (" + episode.Episode.Year + ")");
                        episodeListText.AppendText(Environment.NewLine);
                        episodeListText.AppendText(Environment.NewLine);
                    }
                    else if ((comps.Doctor == "11") && (doctorComboBox.SelectedItem.ToString() == "11"))
                    {
                        episodeListText.AppendText(comps.Name + " (" + comps.Actor + ") ");
                        episodeListText.AppendText(Environment.NewLine);
                        episodeListText.AppendText("\"" + episode.Episode.Title + "\n (" + episode.Episode.Year + ")");
                        episodeListText.AppendText(Environment.NewLine);
                        episodeListText.AppendText(Environment.NewLine);
                    }
                    else if ((comps.Doctor == "12") && (doctorComboBox.SelectedItem.ToString() == "12"))
                    {
                        episodeListText.AppendText(comps.Name + " (" + comps.Actor + ") ");
                        episodeListText.AppendText(Environment.NewLine);
                        episodeListText.AppendText("\"" + episode.Episode.Title + "\n (" + episode.Episode.Year + ")");
                        episodeListText.AppendText(Environment.NewLine);
                        episodeListText.AppendText(Environment.NewLine);
                    }
                }
            } 
        }
    }
}
