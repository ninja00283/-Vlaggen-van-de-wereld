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
        

        /// <summary>
        /// 
        /// Get the images from the map.
        /// 
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            initializeImages();
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
        /// Get the name of the image in the specfied directory.
        /// </summary>
        /// <param name="Directory"></param>
        /// <returns></returns>
        private string getFileName(string Directory) {
            string Name = "";

            Name = Directory.Substring(Directory.LastIndexOf("\\"),Directory.Length);

            return Name;
        }

        private void createAwnsers(int Awnsers)
        {
            for (int i = 0; i < Awnsers; i++)
            {

            }

        }

        private void PictureClick(object sender, EventArgs e)
        {
            setImage();
        }
    }
}
