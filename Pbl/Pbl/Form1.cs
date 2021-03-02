using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pbl
{
    public partial class Form1 : Form
    {
        bool goleft = false;
        bool goright = true;
        bool jumping = false;
        int jumpspeed = 10;
        int force = 70;
        PictureBox player = new PictureBox();
        //PictureBox x = new PictureBox();
        PictureBox[] arr = new PictureBox[22]; // ריצפה
        PictureBox[] mic = new PictureBox[5]; // מיכשולים
        int y = 870;

        int key;
        






        public Form1()
        {

            InitializeComponent();
            KeyDown += new KeyEventHandler(keydown);
            KeyUp += new KeyEventHandler(keyUp);
            
            this.Height = 1200;
            this.Width = 2010;
            player.Height = 50;
            player.Width = 60;
            player.Left = 2;
            player.Top =  870;
            player.BorderStyle = BorderStyle.None;
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            player.Image = Image.FromFile("chara.jpg");
            for (int i=0; i<mic.Length;i++)
            {

                mic[i] = new PictureBox();
                mic[i].Width = 60;
                mic[i].Height = 20;
                mic[i].Top = i * player.Top - 200;
                mic[i].Left = i * player.Left + 280;
                mic[i].BorderStyle = BorderStyle.Fixed3D;
                mic[i].Tag = "k";
                this.Controls.Add(mic[i]);
            }
            for (int i =0; i<arr.Length; i++)
            {
                
                arr[i] = new PictureBox();
                arr[i].Width = 90;
                arr[i].Height = 20;
                arr[i].Location = new Point(player.Width+100 * i, i *player.Height+ 100);
                arr[i].Top = player.Top + 55;
                arr[i].Left = player.Left * 45 * i ;
                arr[i].BorderStyle = BorderStyle.Fixed3D;
                arr[i].Tag = "g";
                this.Controls.Add(arr[i]);
                
            }
            //x.Height = 100;
            //x.Width = this.Width;
            //x.Location = new Point(Height, Width);
            //x.BorderStyle = BorderStyle.None;

            

            this.Controls.Add(player);
            //x.Tag = "platform";



        }

        private void keydown(object sender, KeyEventArgs e)
        {
            timer1.Enabled = true;
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;

            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
            if (e.KeyCode == Keys.Space && !jumping)
            {
                jumping = true;
            }
            if (e.KeyValue==39 )
            {
                key = e.KeyValue;
                if (timer1.Enabled==false)
                {
                    timer1.Enabled = true;
                }
            }
        }
        private void keyUp(object sender, KeyEventArgs e)
        {
            timer1.Enabled = true;
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            if (jumping)
            {
                jumping = false;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (key == 39)
            {
                player.Location = new Point(player.Left + 10, y-6);
                player.Top += jumpspeed;
                if (jumping && force < 0)
                {
                    jumping = false;

                }
                if (goleft)
                {
                    player.Left -= 2;
                }
                if (goright)
                {
                    player.Left += 3;
                }
                if (jumping)
                {
                    jumpspeed -= 12;
                }
                else
                {
                    jumpspeed = 12;
                }
            }
            //player.Left += 5;
            //foreach (Control c in Controls)
            //{
            //    //if (c is PictureBox)
            //    //{
            //    //}
            //    //else

            //    if (c is Button && c.Bounds.IntersectsWith(player.Bounds) == true)
            //    {
            //        player.Left -= 15;
            //        timer1.Enabled = false;
            //        return;
            //    }
            //}
        }



    }



    }
       
        

            
        




        


        

    

