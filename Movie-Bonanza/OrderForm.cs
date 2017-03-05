/*
Application Name        : Movie Bonanza
Author's Name           : Rutul Shah
Student ID              : 200329341 
Application Description : This application lets user to select from a wide range of
                          movies in MOVIE BONANZA. They can also order DVD for their favourite movies
                          or can stream online
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelectForm.cs
{
    public partial class OrderForm : Form
    {

        public SelectForm previousForm;
        double costOfDVD, movieCost;
        public OrderForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// setting all the textboxes with previous details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onLoad(object sender, EventArgs e)
        {
            TitleTextBox.Text = PropertiesClass.MovieDetails[0].Text;
            CategoryTextBox.Text = PropertiesClass.MovieDetails[1].Text;
            CostTextBox.Text = PropertiesClass.MovieDetails[2].Text;

            //getting the image from properties class
            MoviePictureBox.Image = PropertiesClass.MovieImage;
            calculateCost();
        }

        /// <summary>
        /// calculating sub total, sales tax and grand total
        /// </summary>
        private void calculateCost()
        {
            movieCost = double.Parse((CostTextBox.Text).Replace("$", ""));

            SubTotalTextBox.Text = (movieCost + costOfDVD).ToString("C", CultureInfo.CurrentCulture);
            SalesTaxTextBox.Text = ((movieCost + costOfDVD) * 0.13).ToString("C", CultureInfo.CurrentCulture);
            GrandTotalTextBox.Text = ((movieCost + costOfDVD) * 1.13).ToString("C", CultureInfo.CurrentCulture);
        }
        private void OrderDVDCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            AdditionalChargeLabel.Visible = true;
            AdditionalChargeTextBox.Visible = true;

            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked)
            {
                costOfDVD += 10.00;
            }
            else
            {
                costOfDVD -= 10.00;
            }
            AdditionalChargeTextBox.Text = costOfDVD.ToString("C", CultureInfo.CurrentCulture);
            SubTotalTextBox.Text = (movieCost + costOfDVD).ToString("C", CultureInfo.CurrentCulture);
            SalesTaxTextBox.Text = ((movieCost + costOfDVD) * 0.13).ToString("C", CultureInfo.CurrentCulture);
            GrandTotalTextBox.Text = ((movieCost + costOfDVD) * 1.13).ToString("C", CultureInfo.CurrentCulture);

            //setting the value of grand total in properties class so that we can access it in stream form
            PropertiesClass.grandTotal = GrandTotalTextBox.Text;
        }

        /// <summary>
        /// showing about form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        /// <summary>
        /// getting back to select form on back button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Hide();
        }

        /// <summary>
        /// closing order form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.previousForm.Close();
        }

        /// <summary>
        /// exiting form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_Form(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// showing message when print button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please collect this page from printer", "Print", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// sending to stream form when stream butotn is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StreamButton_Click(object sender, EventArgs e)
        {
            StreamForm streamForm = new StreamForm();
            streamForm.previousForm = this;
            streamForm.Show();
            this.Hide();
        }
    }
}
