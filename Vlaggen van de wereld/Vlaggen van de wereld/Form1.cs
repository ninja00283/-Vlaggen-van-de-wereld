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

        public int Order = 0;

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
        }

        private string[] files;

        /// <summary>
        /// Grab directories in your images directory.
        /// </summary>
        private void initializeImages()
        {
            string appRoot = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            files = System.IO.Directory.GetFiles(appRoot + @"\Flags");
        }

        /// <summary>
        /// Randomize the image array and set the image to the first image in the array.
        /// </summary>
        private void setImage()
        {
            Random rnd = new Random();
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
        /// Get the name of the image in the specfied directory.
        /// </summary>
        /// <param name="Directory"></param>
        /// <returns></returns>
        private string getFileName(string Directory) {

            string Name = Directory.Substring(Directory.LastIndexOf("\\"),Directory.Length);

            return Name;
        }

        private void createAwnsers(int Awnsers)
        {
            for (int i = 1; i <= 10; i++)
            {
                Control[] Button = this.Controls.Find("Anwser" + i.ToString(), true);
                if (i <= Awnsers)
                {
                    Button[0].Show();
                    Button[0].Text = "1";
                }
                else {
                    Button[0].Hide();
                }
            }

        }


        /// <summary>
        /// When picture with flag is clicked set and get awnsers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void PictureClick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Order = newImage(Order);
            createAwnsers(rnd.Next(10));
        }
    }
}
