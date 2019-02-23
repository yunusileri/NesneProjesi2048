using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048
{
    public partial class Form1 : Form
    {


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Game g = new Game();
        List<int> resimindex = new List<int>();
        private List<Bitmap> oBitmap = new List<Bitmap>();
        public Form1()
        {
            InitializeComponent();
            oBitmap.Add(new Bitmap(@"images/1.png"));
            oBitmap.Add(new Bitmap(@"images/2.png"));
            oBitmap.Add(new Bitmap(@"images/3.png"));
            oBitmap.Add(new Bitmap(@"images/4.png"));
            oBitmap.Add(new Bitmap(@"images/5.png"));
            oBitmap.Add(new Bitmap(@"images/6.png"));
            oBitmap.Add(new Bitmap(@"images/7.png"));
            oBitmap.Add(new Bitmap(@"images/8.png"));
            oBitmap.Add(new Bitmap(@"images/9.png"));
            oBitmap.Add(new Bitmap(@"images/k0.png"));
            oBitmap.Add(new Bitmap(@"images/10.png"));
            oBitmap.Add(new Bitmap(@"images/11.png"));
            oBitmap.Add(new Bitmap(@"images/12.png"));
            oBitmap.Add(new Bitmap(@"images/13.png"));
            oBitmap.Add(new Bitmap(@"images/14.png"));
            oBitmap.Add(new Bitmap(@"images/15.png"));
            oBitmap.Add(new Bitmap(@"images/16.png"));
            oBitmap.Add(new Bitmap(@"images/17.png"));
            oBitmap.Add(new Bitmap(@"images/18.png"));

            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Draw(g.StartingDraw());

        }
        void Draw(int[][] cell)
        {
            skor.Text = g.Skor.ToString(); //Skor
            Hamle.Text = g.Hamle.ToString(); //Hamle

            Label1_1.Image = oBitmap[ResimId(cell[0][0])];
            Label1_2.Image = oBitmap[ResimId(cell[0][1])];
            Label1_3.Image = oBitmap[ResimId(cell[0][2])];
            Label1_4.Image = oBitmap[ResimId(cell[0][3])];
            Label2_1.Image = oBitmap[ResimId(cell[1][0])];
            Label2_2.Image = oBitmap[ResimId(cell[1][1])];
            Label2_3.Image = oBitmap[ResimId(cell[1][2])];
            Label2_4.Image = oBitmap[ResimId(cell[1][3])];
            Label3_1.Image = oBitmap[ResimId(cell[2][0])];
            Label3_2.Image = oBitmap[ResimId(cell[2][1])];
            Label3_3.Image = oBitmap[ResimId(cell[2][2])];
            Label3_4.Image = oBitmap[ResimId(cell[2][3])];
            Label4_1.Image = oBitmap[ResimId(cell[3][0])];
            Label4_2.Image = oBitmap[ResimId(cell[3][1])];
            Label4_3.Image = oBitmap[ResimId(cell[3][2])];
            Label4_4.Image = oBitmap[ResimId(cell[3][3])];



            if (cell[0][0] != 0)
                Label1_1.Text = cell[0][0].ToString();
            else
                Label1_1.Text = "";

            if (cell[0][1] != 0)
                Label1_2.Text = cell[0][1].ToString();
            else
                Label1_2.Text = "";
            if (cell[0][2] != 0)
                Label1_3.Text = cell[0][2].ToString();
            else
                Label1_3.Text = "";
            if (cell[0][3] != 0)
                Label1_4.Text = cell[0][3].ToString();
            else
                Label1_4.Text = "";
            if (cell[1][0] != 0)
                Label2_1.Text = cell[1][0].ToString();
            else
                Label2_1.Text = "";
            if (cell[1][1] != 0)
                Label2_2.Text = cell[1][1].ToString();
            else
                Label2_2.Text = "";
            if (cell[1][2] != 0)
                Label2_3.Text = cell[1][2].ToString();
            else
                Label2_3.Text = "";
            if (cell[1][3] != 0)
                Label2_4.Text = cell[1][3].ToString();
            else
                Label2_4.Text = "";
            if (cell[2][0] != 0)
                Label3_1.Text = cell[2][0].ToString();
            else
                Label3_1.Text = "";
            if (cell[2][1] != 0)
                Label3_2.Text = cell[2][1].ToString();
            else
                Label3_2.Text = "";
            if (cell[2][2] != 0)
                Label3_3.Text = cell[2][2].ToString();
            else
                Label3_3.Text = "";
            if (cell[2][3] != 0)
                Label3_4.Text = cell[2][3].ToString();
            else
                Label3_4.Text = "";
            if (cell[3][0] != 0)
                Label4_1.Text = cell[3][0].ToString();
            else
                Label4_1.Text = "";
            if (cell[3][1] != 0)
                Label4_2.Text = cell[3][1].ToString();
            else
                Label4_2.Text = "";
            if (cell[3][2] != 0)
                Label4_3.Text = cell[3][2].ToString();
            else
                Label4_3.Text = "";
            if (cell[3][3] != 0)
                Label4_4.Text = cell[3][3].ToString();
            else
                Label4_4.Text = "";



        }
        int ResimId(int id)
        {
            switch (id)
            {
                case 0:
                    return 4;
                case 2:
                    return 5;
                case 4:
                    return 6;
                case 8:
                    return 7;
                case 16:
                    return 8;
                case 32:
                    return 10;
                case 64:
                    return 11;
                case 128:
                    return 12;
                case 256:
                    return 13;
                case 512:
                    return 14;
                case 1024:
                    return 15;
                case 2048:
                    return 16;
                case 4096:
                case 8192:
                case 16384:
                    return 17;
            }
            return 4;

        }

        private void TusBas(object sender, KeyEventArgs e)
        {

            int h = 0;
            switch (e.KeyCode)
            {
                case Keys.W:
                    h = 1;
                    break;
                case Keys.S:
                    h = 2;
                    break;
                case Keys.A:

                    h = 4;
                    break;
                case Keys.D:

                    h = 3;
                    break;

            }
            Draw(g.Hareket(h));
        }

        private void BtnGeriAl_Click(object sender, EventArgs e)
        {

        }
    }
}
