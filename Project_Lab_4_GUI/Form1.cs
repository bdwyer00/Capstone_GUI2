using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Project_Lab_4_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Show_Data_Click(object sender, EventArgs e)
        {
            baseRecoringPNG.ImageLocation = @"C:\Users\badfr\OneDrive\Desktop\Undergrad Academics\Spring 2023\Capstone Project Lab\PNG Example.png";
            sampleRecordingPNG.ImageLocation = @"C:\Users\badfr\OneDrive\Desktop\Undergrad Academics\Spring 2023\Capstone Project Lab\PNG Example.png";

            string text = System.IO.File.ReadAllText(@"C:\Users\badfr\OneDrive\Desktop\C# .txt example.txt");
            string[] text2 = text.Split(','); // split string into an array of the differnt data points seperated by a comma
           
            //MessageBox.Show("Number of data points in string: " + Convert.ToString(text2.Count()));
   
            sampleRecordingPNG.Visible = true;

            progressBar1.Value = 100;

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            sampleRecordingPNG.Visible = false;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure that you would like to close the application?", "Application Closing", MessageBoxButtons.YesNo);

            // If the yes button was pressed ...
            if (result == DialogResult.Yes)
            {
                // close the form
                Application.Exit();
            }
        }

        private void playBaseButton_Click(object sender, EventArgs e)
        {
            //playBaseButton.Enabled = false;
            //playSampleButton.Enabled = true;
            SoundPlayer bplayer = new SoundPlayer(@"C:\Users\badfr\OneDrive\Documents\Sound Recordings\Recording.wav");
            bplayer.Play();
        }

        private void playSampleButton_Click(object sender, EventArgs e)
        {
            //playSampleButton.Enabled = false;
            //playBaseButton.Enabled = true;
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\badfr\OneDrive\Documents\Sound Recordings\Recording1.wav");
            splayer.Play();
        }
    }
}
