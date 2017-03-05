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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelectForm.cs
{
    public partial class StreamForm : Form
    {
        public OrderForm previousForm;
        public StreamForm()
        {
            InitializeComponent();
            showLabel();
        }

        /// <summary>
        /// showing user cost and name of the movie 
        /// </summary>
        private void showLabel()
        {
            Mainlabel.Text = "Thank you for choosing Movie Bonanza !" + "\n" + "\n" + "Your credit card will be charged with" + " " + PropertiesClass.grandTotal + "\n" + "\n" + "\"" + PropertiesClass.MovieDetails[0].Text + "\"" + " " + "will begin streaming shortly";
        }

        /// <summary>
        /// closing stream form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StreamForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.previousForm.Close();
        }

        private void Exit_Form(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
