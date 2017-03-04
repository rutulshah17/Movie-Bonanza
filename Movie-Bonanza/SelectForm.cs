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

        public SelectForm()
        {
            InitializeComponent();
            PropertiesClass.MovieDetails = new List<TextBox>();
            _initializeTextBoxes();
        }

        private void _initializeTextBoxes()
        {
            PropertiesClass.MovieDetails.Add(TitleTextBox);
            PropertiesClass.MovieDetails.Add(CategoryTextBox);
            PropertiesClass.MovieDetails.Add(CostTextBox);
        }

        private void MovieListBox_Click(object sender, EventArgs e)
        {

            TitleTextBox.Text = MovieListBox.SelectedItem.ToString();

            if (TitleTextBox.Text == "Company Men" || TitleTextBox.Text == "The Way Back")
            {
                CategoryTextBox.Text = "Drama";
                CostTextBox.Text = "$1.99";

                if (TitleTextBox.Text == "Company Men")
                {
                    MoviePictureBox.Image = Properties.Resources.company_men;
                }
                else
                {
                    MoviePictureBox.Image = Properties.Resources.The_Way_Back;
                }

            }
            else if (TitleTextBox.Text == "Death Race 2" || TitleTextBox.Text == "The Green Hornet")
            {
                CategoryTextBox.Text = "Action";
                CostTextBox.Text = "$2.99";

                if (TitleTextBox.Text == "Death Race 2")
                {
                    MoviePictureBox.Image = Properties.Resources.death_race_2;
                }
                else
                {
                    MoviePictureBox.Image = Properties.Resources.The_Green_Hornet;
                }
            }
            else if (TitleTextBox.Text == "Footloose" || TitleTextBox.Text == "Real Steel")
            {
                CategoryTextBox.Text = "New Releases";
                CostTextBox.Text = "$4.99";

                if (TitleTextBox.Text == "Footloose")
                {
                    MoviePictureBox.Image = Properties.Resources.footloose;
                }
                else
                {
                    MoviePictureBox.Image = Properties.Resources.real_steel;
                }
            }
            else if (TitleTextBox.Text == "Gnomeo and Juliet")
            {
                CategoryTextBox.Text = "Family";
                CostTextBox.Text = "$0.99";
                MoviePictureBox.Image = Properties.Resources.Gnomeo_and_Juliet;
            }
            else if (TitleTextBox.Text == "I am Number Four" || TitleTextBox.Text == "Season of the Witch")
            {
                CategoryTextBox.Text = "Sci-Fi";
                CostTextBox.Text = "$2.99";

                if (TitleTextBox.Text == "I am Number Four")
                {
                    MoviePictureBox.Image = Properties.Resources.I_am_Number_Four;
                }
                else
                {
                    MoviePictureBox.Image = Properties.Resources.Season_of_the_Witch;
                }
            }
            else if (TitleTextBox.Text == "No Strings Attached" || TitleTextBox.Text == "The Dilemma")
            {
                CategoryTextBox.Text = "Comedy";
                CostTextBox.Text = "$1.99";

                if (TitleTextBox.Text == "No Strings Attached")
                {
                    MoviePictureBox.Image = Properties.Resources.No_Strings_Attached;
                }
                else
                {
                    MoviePictureBox.Image = Properties.Resources.The_Dilemma;
                }

            }
            else if (TitleTextBox.Text == "The Rite")
            {
                CategoryTextBox.Text = "Horror";
                CostTextBox.Text = "$2.99";
                MoviePictureBox.Image = Properties.Resources.The_Rite;
            }
            else
            {
                CategoryTextBox.Text = "Thriller";
                CostTextBox.Text = "$1.99";
                MoviePictureBox.Image = Properties.Resources.The_Roommate;
            }

            PropertiesClass.MovieImage = MoviePictureBox.Image;


            if (TitleTextBox.Text != null)
            {
                NextButton.Enabled = true;
            }


        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.previousForm = this;
            orderForm.Show();
            this.Hide();

        }
    }
}
