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



namespace Vlaggen_van_de_wereld
{
    public partial class Form1 : Form
    {
        private Random rnd = new Random();
        FlagViewer flagViewer;
        public int Order = 0;
        public int Difficulty = 2;

        /// <summary>
        /// 
        /// Get the images from the map.
        /// 
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            initializeImages();

            setImage();

            flagViewer = new FlagViewer();
        }

        private string[] files;

        /// <summary>
        /// Grab directories in your images directory.
        /// </summary>
        private void initializeImages()
        {
            files = System.IO.Directory.GetFiles("..\\..\\.\\flags");
        }

        

        /// <summary>
        /// Randomize the image array and set the image to the first image in the array.
        /// </summary>
        private void setImage()
        {
            files = files.OrderBy(x => rnd.Next()).ToArray();
            FlagBox.ImageLocation = files[0];
            Debug.WriteLine(files[0]);
        }

        /// <summary>
        /// Set the current image to the next image in the array.
        /// </summary>
        private int newImage(int order)
        {
            order++;
            FlagBox.ImageLocation = files[order];
            Debug.WriteLine(files[order]);
            return order;
        }

        /// <summary>
        /// Set the current image to the next image in the array.
        /// </summary>
        private string randomImage()
        {
            return files[rnd.Next(files.Length)];
        }

        /// <summary>
        /// Take a string of a directory(string Directory) and take the name of the file.
        /// 
        /// Currently takes string and cuts of th last 4 characters (.png).
        /// This will be aproblem with longer file types.
        /// 
        /// to do
        /// 
        /// support for multiple file types
        /// </summary>
        /// <param name="Directory"></param>
        /// <returns></returns>
        private string getFileName(string Directory) {
            Debug.Print(Directory);
            string Name = Directory.Substring(Directory.LastIndexOf("\\")+1,Directory.Length-Directory.LastIndexOf("\\")-5);

            return Name;
        }


        /// <summary>
        /// 
        /// to do write comment
        /// 
        /// </summary>
        /// <param name="AnswerAmount"></param>
        private void createAwnsers(int AnswerAmount)
        {
            AnswerAmount *= 3;
            String[] Answers = new String[AnswerAmount];

            int correctAnswer = rnd.Next(AnswerAmount);

            for (int i = 0; i < AnswerAmount; i++)
            {
                if (i == correctAnswer) {
                    Answers[i] = getFileName(files[Order]);
                }
                else {
                    Answers[i] = getFileName(randomImage());

                    
                }
            }


            
            for (int i = 1; i <= 9; i++)
            {
                Control[] Button = this.Controls.Find("Anwser" + i.ToString(), true);
                if (i <= AnswerAmount)
                {
                    Button[0].Show();
                    Button[0].Text = Answers[i-1];
                }
                else {
                    Button[0].Hide();
                }
            }

        }


        /// <summary>
        /// When picture with flag is clicked set and get new awnsers and a new flag
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void PictureClick(object sender, EventArgs e)
        {
            Order = newImage(Order);
            createAwnsers(Difficulty);
        }

        private void ViewerMode(object sender, MouseEventArgs e)
        {
            if (flagViewer.IsDisposed)
            {
                flagViewer = new FlagViewer();
            }

            flagViewer.Show();
        }
    }
}
