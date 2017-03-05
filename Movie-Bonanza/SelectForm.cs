/*
Application Name        : Movie Bonanza
Author's Name           : Rutul Shah
Student ID              : 200329341 
Application Description : This application lets user to select from a wide range of
                          movies in MOVIE BONANZA. They can also order DVD for their favourite movies
                          or can stream online
*/
using Movie_Bonanza.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelectForm.cs
{
    public partial class SelectForm : Form
    {

        public SplashForm previousForm;
        public String name;

        public SelectForm()
        {
            InitializeComponent();

            //initializing list consists of textboxes
            PropertiesClass.MovieDetails = new List<TextBox>();

            _initializeTextBoxes();
        }



        /// <summary>
        /// adding textboxes to list
        /// </summary>
        private void _initializeTextBoxes()
        {
            PropertiesClass.MovieDetails.Add(TitleTextBox);
            PropertiesClass.MovieDetails.Add(CategoryTextBox);
            PropertiesClass.MovieDetails.Add(CostTextBox);
        }

        /// <summary>
        /// getting text from ListBox and assigning it to TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MovieListBox_Click(object sender, EventArgs e)
        {

            TitleTextBox.Text = MovieListBox.SelectedItem.ToString();

            if (TitleTextBox.Text == "Company Men" || TitleTextBox.Text == "The Way Back")
            {
                CategoryTextBox.Text = "Drama";
                CostTextBox.Text = "$1.99";

                if (TitleTextBox.Text == "Company Men")
                {
                    MoviePictureBox.Image = Resources.company_men;
                }
                else
                {
                    MoviePictureBox.Image = Resources.The_Way_Back;
                }

            }
            else if (TitleTextBox.Text == "Death Race 2" || TitleTextBox.Text == "The Green Hornet")
            {
                CategoryTextBox.Text = "Action";
                CostTextBox.Text = "$2.99";

                if (TitleTextBox.Text == "Death Race 2")
                {
                    MoviePictureBox.Image = Resources.death_race_2;
                }
                else
                {
                    MoviePictureBox.Image = Resources.The_Green_Hornet;
                }
            }
            else if (TitleTextBox.Text == "Footloose" || TitleTextBox.Text == "Real Steel")
            {
                CategoryTextBox.Text = "New Releases";
                CostTextBox.Text = "$4.99";

                if (TitleTextBox.Text == "Footloose")
                {
                    MoviePictureBox.Image = Resources.footloose;
                }
                else
                {
                    MoviePictureBox.Image = Resources.real_steel;
                }
            }
            else if (TitleTextBox.Text == "Gnomeo and Juliet")
            {
                CategoryTextBox.Text = "Family";
                CostTextBox.Text = "$0.99";
                MoviePictureBox.Image = Resources.Gnomeo_and_Juliet;
            }
            else if (TitleTextBox.Text == "I am Number Four" || TitleTextBox.Text == "Season of the Witch")
            {
                CategoryTextBox.Text = "Sci-Fi";
                CostTextBox.Text = "$2.99";

                if (TitleTextBox.Text == "I am Number Four")
                {
                    MoviePictureBox.Image = Resources.I_am_Number_Four;
                }
                else
                {
                    MoviePictureBox.Image = Resources.Season_of_the_Witch;
                }
            }
            else if (TitleTextBox.Text == "No Strings Attached" || TitleTextBox.Text == "The Dilemma")
            {
                CategoryTextBox.Text = "Comedy";
                CostTextBox.Text = "$1.99";

                if (TitleTextBox.Text == "No Strings Attached")
                {
                    MoviePictureBox.Image = Resources.No_Strings_Attached;
                }
                else
                {
                    MoviePictureBox.Image = Resources.The_Dilemma;
                }

            }
            else if (TitleTextBox.Text == "The Rite")
            {
                CategoryTextBox.Text = "Horror";
                CostTextBox.Text = "$2.99";
                MoviePictureBox.Image = Resources.The_Rite;
            }
            else
            {
                CategoryTextBox.Text = "Thriller";
                CostTextBox.Text = "$1.99";
                MoviePictureBox.Image = Resources.The_Roommate;
            }

            //after the image is set, it is stored in properties class so that Order form could access it
            PropertiesClass.MovieImage = MoviePictureBox.Image;

            //if any value is set in the textbox, then enabling the next button
            if (TitleTextBox.Text != null)
            {
                NextButton.Enabled = true;
            }

        }

        /// <summary>
        /// creating object of Orderform on clicking next button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.previousForm = this;
            orderForm.Show();
            this.Hide();
        }

        /// <summary>
        /// closing select form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.previousForm.Close();
        }
    }
}
