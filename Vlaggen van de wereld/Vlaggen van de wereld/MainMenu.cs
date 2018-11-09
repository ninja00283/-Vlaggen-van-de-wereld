using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vlaggen_van_de_wereld
{
    public partial class MainMenu : Form
    {

        FlagViewer flagViewer;
        QuizBox quizBox;

        public MainMenu()
        {
            InitializeComponent();

            flagViewer = new FlagViewer();
            quizBox = new QuizBox();
        }


        private void closeClick(object sender, EventArgs e)
        {
            Close();
        }

        private void FlagViewerClick(object sender, EventArgs e)
        {
            if (flagViewer.IsDisposed)
            {
                flagViewer = new FlagViewer();
            }

            flagViewer.Show();
        }

        private void QuizBoxClick(object sender, EventArgs e)
        {
            if (quizBox.IsDisposed)
            {
                quizBox = new QuizBox();
            }
            quizBox.Show();
        }
    }
}
