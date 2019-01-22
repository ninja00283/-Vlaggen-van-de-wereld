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
    public partial class ScoreScreen : Form
    {
        List<QuizBox.Questions> accepted;
        public ScoreScreen(List<QuizBox.Questions> Accepted)
        {
            InitializeComponent();
            accepted = Accepted;
            Show();

            for (int i = 0; i < accepted.Count; i++)
            {
                Debug.Print(accepted[i].FlagPath);

                PictureBox newFlagPicture = new PictureBox
                {
                    ImageLocation = accepted[i].FlagPath
                };

                FlowLayoutPanel FlowPictureBox = new FlowLayoutPanel();

                Label RightAnswer = new Label();
                Label SelectedAnswer = new Label();

                RightAnswer.Text = accepted[i].RightAnswer;
                SelectedAnswer.Text = accepted[i].SelectedAnswer;
                RightAnswer.Parent = FlowPictureBox;
                SelectedAnswer.Parent = newFlagPicture;
                newFlagPicture.Parent = FlowPictureBox;
                flowLayoutPanel.Controls.Add(FlowPictureBox);

                if (accepted[i].RightAnswer == accepted[i].SelectedAnswer) {
                    FlowPictureBox.BackColor = Color.Green;
                }
                else{
                    FlowPictureBox.BackColor = Color.Red;
                }
                newFlagPicture.Size = new Size(100, 100);
                newFlagPicture.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }


    }
}
