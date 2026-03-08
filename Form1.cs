using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Diagnostics;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        private bool change = false;
        private Image alternateImage = null;
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            this.BackColor = Color.FromArgb(rand.Next(200), rand.Next(200), rand.Next(256));
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo("https://github.com/ghtfy")
            {
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void button3_Click(object sender, EventArgs e)   //이미지 변경 버튼 작업 중
        {
           
            if (pictureBox1.Tag == null)
                pictureBox1.Tag = pictureBox1.Image;

            // Load images from Form1.resx keys: "pictureBox2.image" and "pictureBox3.image"
            var rm = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Image imgA = rm.GetObject("pictureBox2.image") as Image;
            Image imgB = rm.GetObject("pictureBox3.image") as Image;

            
            if (imgA == null) imgA = pictureBox1.Tag as Image ?? SystemIcons.Information.ToBitmap();
            if (imgB == null) imgB = SystemIcons.Information.ToBitmap();

            // Toggle between imgA and imgB
            if (change)
            {
                pictureBox1.Image = imgA;
            }
            else
            {
                pictureBox1.Image = imgB;
            }

            change = !change;
        }
    }
}