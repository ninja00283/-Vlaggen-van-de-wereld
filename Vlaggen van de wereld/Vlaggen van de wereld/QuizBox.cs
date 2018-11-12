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
    public partial class QuizBox : Form
    {
        private Random rnd = new Random();
        public int Order = 1;
        public int Difficulty = 2;

        public List<string> Accepted = new List<string>();

        public String[] Answers;

        public RadioButton Answer;

        /// <summary>
        /// 
        /// Get the images from the map.
        /// 
        /// </summary>
        private void QuizBoxLoad(object sender, EventArgs e)
        {
            Debug.Write("loaded");
            InitializeImages();


            bool success = PreviousImage();
            if (success) { CreateAwnsers(Difficulty); }
        }

        public QuizBox()
        {
            InitializeComponent();
        }

        private string[] files;

        /// <summary>
        /// Grab directories in your images directory.
        /// </summary>
        private void InitializeImages()
        {
            files = System.IO.Directory.GetFiles("..\\..\\.\\flags");
        }

        

        /// <summary>
        /// Randomize the image array and set the image to the first image in the array.
        /// </summary>
        private void SetImage()
        {
            files = files.OrderBy(x => rnd.Next()).ToArray();
            FlagBox.ImageLocation = files[0];
        }

        /// <summary>
        /// Set the current image to the next image in the array.
        /// </summary>
        private bool NewImage()
        {
            bool Success = false;
            if (Order == files.Length-1)
            {
                MessageBox.Show("Last flag already reached",
                "Last flag",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning // for Warning  
                //MessageBoxIcon.Error // for Error 
                //MessageBoxIcon.Information  // for Information
                //MessageBoxIcon.Question // for Question
               );
                Success = false;
            }
            else
            {
                Order++;
                FlagBox.ImageLocation = files[Order];
                Success = true;
            }
            return Success;
        }

        /// <summary>
        /// Set the current image to the previous image in the array.
        /// </summary>
        private bool PreviousImage()
        {
            bool Success = false;
            if (Order == 0)
            {
                MessageBox.Show("first flag already reached",
                "first flag",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning // for Warning  
                //MessageBoxIcon.Error // for Error 
                //MessageBoxIcon.Information  // for Information
                //MessageBoxIcon.Question // for Question
               );
               Success = false;
            }
            else
            {
                Order--;
                FlagBox.ImageLocation = files[Order];
                Success = true;
            }
            return Success;
        }

        /// <summary>
        /// Set the current image to the next image in the array.
        /// </summary>
        private string RandomImage()
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
        private string GetFileName(string Directory) {
            string Name = Directory.Substring(Directory.LastIndexOf("\\")+1,Directory.Length-Directory.LastIndexOf("\\")-5);

            return Name;
        }


        /// <summary>
        /// 
        /// to do write comment
        /// 
        /// </summary>
        /// <param name="AnswerAmount"></param>
        private void CreateAwnsers(int AnswerAmount)
        {
            AnswerAmount *= 3;
            Answers = new String[AnswerAmount];

            int correctAnswer = rnd.Next(AnswerAmount);

            for (int i = 0; i < AnswerAmount; i++)
            {
                if (i == correctAnswer) {
                    Answers[i] = GetFileName(files[Order]);
                }
                else {
                    Answers[i] = GetFileName(RandomImage());

                    
                }
            }


            for (int i = 1; i <= 9; i++)
            {
                Control[] Button = this.Controls.Find("Answer_" + i.ToString(), true);
                if (i <= AnswerAmount)
                {
                    Button[0].Show();
                    Button[0].Text = Answers[i - 1].Replace("_", " ");
                }
                else
                {
                    Button[0].Hide();
                }
            }

        }

        private void AcceptClick(object sender, EventArgs e)
        {
   
            Accepted.Add(Answers[Int32.Parse(Answer.Name.Split('_').Last())-1] + "~" + GetFileName(files[Order]));
            bool success = NewImage();
            if (success) { CreateAwnsers(Difficulty); }

        }

        private void PreviousClick(object sender, EventArgs e)
        {
            bool success = PreviousImage();
            if (success) { CreateAwnsers(Difficulty); }
        }

        private void NextClick(object sender, EventArgs e)
        {
            bool success = NewImage();
            if (success) { CreateAwnsers(Difficulty); }
        }

        private void AwnserClick(object sender, EventArgs e)
        {
            Answer = (RadioButton)sender;
        }

        private void DoneClick(object sender, EventArgs e)
        {
            int Correct = 0;
            int Incorrect = 0;
            for (int i = 0; i < Accepted.Count(); i++)
            {
                string[] CurrentAnswer = Accepted[i].Split('~');
                if (CurrentAnswer.First() == CurrentAnswer.Last())
                {
                    Correct++;
                }
                else
                {
                    Incorrect++;
                }
            }
            Debug.Print(Correct.ToString() + "-" + Incorrect.ToString() + "-"+ Accepted.Count());
        }
    }
}
