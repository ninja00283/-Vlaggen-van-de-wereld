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
        public int Order = -1;
        public int Difficulty = 2;

        public List<Questions> Accepted = new List<Questions>();

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
            bool Init = InitializeImages();
            if (!Init)
            {
                Close();
            }
            else { 
                SetImage();
                bool success = NewImage();
                if (success) { CreateAwnsers(Difficulty); }
            }
        }

        public QuizBox()
        {
            InitializeComponent();
        }

        private List<string> files = new List<string>();

        /// <summary>
        /// Grab directories in your images directory.
        /// </summary>
        private bool InitializeImages()
        {
            for (int i = 0; i < MainMenu.SelectedFlags.Count; i++)
            {
                if (MainMenu.SelectedFlags[i].Used)
                {
                    files.Add(MainMenu.SelectedFlags[i].Path);
                }
            }
            if (files.Count <= 1) {
                MessageBox.Show("Not enough flags",
                "Not enough flags, please select more",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning // for Warning  
                //MessageBoxIcon.Error // for Error 
                //MessageBoxIcon.Information  // for Information
                //MessageBoxIcon.Question // for Question
               );
                return false;
            }
            Debug.Print(files.Count.ToString());
            return true;
        }



        /// <summary>
        /// Randomize the image array and set the image to the first image in the array.
        /// </summary>
        private void SetImage()
        {
            for (int i = 0; i < files.Count; i++)
            {
                string temp = files[i];
                int randomIndex = rnd.Next(i, files.Count);
                files[i] = files[randomIndex];
                files[randomIndex] = temp;
            }
        }

        /// <summary>
        /// Set the current image to the next image in the array.
        /// </summary>
        private bool NewImage()
        {
            bool Success = false;
            if (Order == files.Count - 1)
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
            if (Order == 1)
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
            return files[rnd.Next(files.Count)];
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
            string Name = Directory.Substring(Directory.LastIndexOf("\\") + 1, Directory.Length - Directory.LastIndexOf("\\") - 5);

            return Name;
        }


        /// <summary>
        /// 
        /// take the difficulty times 3 and store it as AnswerAmount.
        /// 
        /// then do a for loop and select an existing flag or the right answer and store it in Answers
        /// 
        /// then set the text of the radio button to the Answers
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
        /// <summary>
        /// 
        /// todo
        /// rwrite comments
        /// 
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AcceptClick(object sender, EventArgs e)
        {

            //Accepted.Add(Answers[Int32.Parse(Answer.Name.Split('_').Last()) - 1] + "~" + GetFileName(files[Order]));

            Questions question = new Questions(Order, GetFileName( files[Order]), Answers[Int32.Parse(Answer.Name.Split('_').Last()) - 1]);

            Accepted.Add(question);
            bool success = NewImage();
            if (success) { CreateAwnsers(Difficulty); }

        }

        //if arrow is clicked
        private void PreviousClick(object sender, EventArgs e)
        {
            bool success = PreviousImage();
            if (success) { CreateAwnsers(Difficulty); }
        }

        //if the right arrow is clicked
        private void NextClick(object sender, EventArgs e)
        {
            bool success = NewImage();
            if (success) { CreateAwnsers(Difficulty); }
        }

        //if accept is clicked
        private void AwnserClick(object sender, EventArgs e)
        {
            Answer = (RadioButton)sender;
        }


        //if done is clicked
        private void DoneClick(object sender, EventArgs e)
        {
            int Correct = 0;
            int Incorrect = 0;
            for (int i = 0; i < Accepted.Count(); i++)
            {
                //string[] CurrentAnswer = Accepted[i].Split('~');
                if (Accepted[i].SelectedAnswer == Accepted[i].RightAnswer)
                {
                    Correct++;
                }
                else
                {
                    Incorrect++;
                }


            }
            Debug.Print(Correct.ToString() + "-" + Incorrect.ToString() + "-" + Accepted.Count());
        }

        /// <summary>
        /// take the posistion of the answer, the rightAnswer and the selectedAnswer
        /// </summary>
        public class Questions
        {

            public int Position { get; set; }
            public string RightAnswer { get; set; }
            public string SelectedAnswer { get; set; }

            public Questions(int position , string rightAnswer, string selectedAnswer)
            {
                Position = position;
                RightAnswer = rightAnswer;
                SelectedAnswer = selectedAnswer;
            }
        } 

    }

    

    

}
