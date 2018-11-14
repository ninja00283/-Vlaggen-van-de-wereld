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
    public partial class FlagViewer : Form
    {
        private string[] files;

        private int X;
        private int Y;

        public FlagViewer()
        {
            InitializeComponent();
        }

        private void FlagViewer_Load(object sender, EventArgs e)
        {

            AdjustFormScrollbars(true);
            this.Panel.VerticalScroll.Visible = true;

            files = System.IO.Directory.GetFiles("..\\..\\.\\flags");

            X = 10;
            Y = 10;

            for (int i = 0; i < files.Length; i++)
            {


                Debug.Print(i.ToString());

                PictureBox newFlagPicture = new PictureBox();

                newFlagPicture.ImageLocation = files[i];
                this.Panel.Controls.Add(newFlagPicture);

                newFlagPicture.Size = new Size(100,100);
                newFlagPicture.SizeMode = PictureBoxSizeMode.Zoom;

                if (X + newFlagPicture.Width >= this.Width - 20)
                {
                    X = 10;
                    Y += newFlagPicture.Height;
                }
                else {
                    X += newFlagPicture.Width + 10;
                }

                newFlagPicture.Location = new Point(X,Y);

            }
        }
    }
}
