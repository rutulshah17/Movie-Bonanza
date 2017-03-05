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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelectForm.cs
{
    class PropertiesClass
    {
        public static List<TextBox> MovieDetails { get; set; }

        public static Image MovieImage { get; set; }

        public static String grandTotal { get; set; }

    }
}
