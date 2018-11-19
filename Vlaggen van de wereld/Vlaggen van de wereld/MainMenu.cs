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

        public static List<Flags> SelectedFlags = new List<Flags>();

        FlagViewer flagViewer;
        QuizBox quizBox;

        public string[] files;

        public MainMenu()
        {
            InitializeComponent();

            flagViewer = new FlagViewer();
            quizBox = new QuizBox();

            files = System.IO.Directory.GetFiles("..\\..\\.\\flags");
            for (int i = 0; i < files.Length; i++)
            {
                SelectedFlags.Add(new Flags(files[i], false));
            }
        }

        public class  Flags
        {
            public string Path { get; set; }
            public bool Used { get; set; }

            public Flags(string path, bool used)
            {
                Path = path;
                Used = used;
            }
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
