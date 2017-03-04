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

        private void onLoad(object sender, EventArgs e)
        {
            TitleTextBox.Text = PropertiesClass.MovieDetails[0].Text;
            CategoryTextBox.Text = PropertiesClass.MovieDetails[1].Text;
            CostTextBox.Text = PropertiesClass.MovieDetails[2].Text;

            MoviePictureBox.Image = PropertiesClass.MovieImage;
            calculateCost();
        }

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
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Hide();
        }

        private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.previousForm.Close();
            this.previousForm.previousForm.Close();
        }

        private void Exit_Form(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please collect this page from printer", "Print", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //PrintPreviewDialog.Show(this.previousForm);
        }

        private void StreamButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Thank you for choosing Movie Bonanza !" + "\n" + "\n" + "Your credit Card will be charged with" + " " + GrandTotalTextBox.Text + "\n" + "\n" + "Your movie" + " " + "\"" + PropertiesClass.MovieDetails[0].Text.ToUpper() + "\"" + " " + "will begin to stream shortly !", "Your Order");
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
