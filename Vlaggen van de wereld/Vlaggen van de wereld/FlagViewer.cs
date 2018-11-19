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
        

        

        private int X;
        private int Y;

        public FlagViewer()
        {
            InitializeComponent();
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
        private string GetFileName(string Directory)
        {
            string Name = Directory.Substring(Directory.LastIndexOf("\\") + 1, Directory.Length - Directory.LastIndexOf("\\") - 5);

            return Name;
        }


        /// <summary>
        /// 
        /// get the flags from the directory and then create a picturebox with a tag and a label for each
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlagViewer_Load(object sender, EventArgs e)
        {

            AdjustFormScrollbars(true);
            this.Panel.VerticalScroll.Visible = true;

            

            X = 40;
            Y = 10;

            for (int i = 0; i < MainMenu.SelectedFlags.Count; i++)
            {


                Debug.Print(i.ToString());

                PictureBox newFlagPicture = new PictureBox
                {
                    ImageLocation = MainMenu.SelectedFlags[i].Path
                };
                Label label = new Label();
                ToolTip Tag = new ToolTip();
                Tag.SetToolTip(newFlagPicture, GetFileName(MainMenu.SelectedFlags[i].Path).Replace('_',' '));
                label.Parent = newFlagPicture;
                label.Text = GetFileName(MainMenu.SelectedFlags[i].Path).Replace('_', ' ');

                newFlagPicture.Click += PictureClick;


                PictureBox newFlagborder = new PictureBox();


                newFlagborder.Name = "FlagBorder" + i.ToString();
                newFlagPicture.Name = "FlagImage" + i.ToString();

                
                this.Panel.Controls.Add(newFlagPicture);
                this.Panel.Controls.Add(newFlagborder);

                newFlagPicture.Size = new Size(100,100);
                newFlagborder.Size = new Size(20, 20);
                newFlagPicture.SizeMode = PictureBoxSizeMode.Zoom;


                if (X + newFlagPicture.Width >= this.Width - 40)
                {
                    X = 40;
                    Y += newFlagPicture.Height;
                }
                else {
                    X += newFlagPicture.Width + 10;
                }
 
                newFlagborder.BackColor = Color.Gray;
                
            }
        }

        private void PictureClick(object sender, EventArgs e)
        {
            PictureBox Sender = sender as PictureBox;
            for (int i = 0; i < MainMenu.SelectedFlags.Count; i++)
            {
                if (MainMenu.SelectedFlags[i].Path == Sender.ImageLocation)
                {
                    MainMenu.SelectedFlags[i].Used = !MainMenu.SelectedFlags[i].Used;
                    Control[] FlagImage = this.Controls.Find("FlagImage" + i.ToString(), true);
                    Control[] FlagBorder = this.Controls.Find("FlagBorder" + i.ToString(), true);
                    PictureBox flagBorder = FlagBorder.First() as PictureBox;
                    if (MainMenu.SelectedFlags[i].Used)
                    { 
                        flagBorder.BackColor = Color.Green;
                    }
                    else
                    {

                        flagBorder.BackColor = Color.Gray;
                    }

                }
            }
        }

        

    }
}
