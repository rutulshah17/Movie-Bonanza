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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        //showing splash form and hiding it after 3 seconds
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            SelectForm selectForm = new SelectForm();
            selectForm.previousForm = this;


            this.SplashFormTimer.Enabled = false;
            selectForm.Show();
            this.Hide();
        }
    }
}
