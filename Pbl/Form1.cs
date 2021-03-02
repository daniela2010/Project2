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
        
        bool jumping = false;
        bool right, left;
       
        PictureBox bad = new PictureBox();
        PictureBox player = new PictureBox();
        
        PictureBox floor= new PictureBox(); // ריצפה
        PictureBox mic = new PictureBox(); // מיכשולים
        PictureBox mic1 = new PictureBox();
        PictureBox mic2 = new PictureBox();
        PictureBox mic3 = new PictureBox();
        PictureBox mic4 = new PictureBox();
        PictureBox mic5 = new PictureBox();
        PictureBox mic6 = new PictureBox();
        PictureBox mic7 = new PictureBox();
        PictureBox next = new PictureBox();
        PictureBox bad1 = new PictureBox();
        PictureBox shoot = new PictureBox();
        

        int key;
        






        public Form1()
        {

            InitializeComponent();
            KeyDown += new KeyEventHandler(keydown);
            KeyUp += new KeyEventHandler(keyUp);
            
            this.Height = 1200;
            this.Width = 2010;

            shoot.Height = 10;
            shoot.Width = 10;
            shoot.BorderStyle = BorderStyle.None;
            shoot.SizeMode = PictureBoxSizeMode.StretchImage;
            shoot.Image = Image.FromFile("shot.png");


            mic.Height = this.Height / 30;
            mic.Width = this.Width / 11;
            mic.Location = new Point(110, 860);
            mic.BorderStyle = BorderStyle.None;
            mic.SizeMode = PictureBoxSizeMode.StretchImage;
            mic.Image = Image.FromFile("stage.jpg");

            mic1.Height = mic.Height;
            mic1.Width = mic.Width;
            mic1.Location = new Point(300, 780);
            mic1.BorderStyle = BorderStyle.None;
            mic1.SizeMode = PictureBoxSizeMode.StretchImage;
            mic1.Image = Image.FromFile("stage.jpg");

            mic2.Height = mic.Height;
            mic2.Width = mic.Width;
            mic2.Location = new Point(470, 715);
            mic2.BorderStyle = BorderStyle.None;
            mic2.SizeMode = PictureBoxSizeMode.StretchImage;
            mic2.Image = Image.FromFile("stage.jpg");

            mic3.Height = mic.Height;
            mic3.Width = mic.Width;
            mic3.Location = new Point(660, 675);
            mic3.BorderStyle = BorderStyle.None;
            mic3.SizeMode = PictureBoxSizeMode.StretchImage;
            mic3.Image = Image.FromFile("stage.jpg");

            mic4.Height = mic.Height;
            mic4.Width = mic.Width;
            mic4.Location = new Point(840, 630);
            mic4.BorderStyle = BorderStyle.None;
            mic4.SizeMode = PictureBoxSizeMode.StretchImage;
            mic4.Image = Image.FromFile("stage.jpg");

            mic5.Height = mic.Height;
            mic5.Width = mic.Width;
            mic5.Location = new Point(950, 550);
            mic5.BorderStyle = BorderStyle.None;
            mic5.SizeMode = PictureBoxSizeMode.StretchImage;
            mic5.Image = Image.FromFile("stage.jpg");

            mic6.Height = mic.Height;
            mic6.Width = mic.Width;
            mic6.Location = new Point(1120, 680);
            mic6.BorderStyle = BorderStyle.None;
            mic6.SizeMode = PictureBoxSizeMode.StretchImage;
            mic6.Image = Image.FromFile("stage.jpg");

            mic7.Height = mic.Height;
            mic7.Width = mic.Width;
            mic7.Location = new Point(1280, 600);
            mic7.BorderStyle = BorderStyle.None;
            mic7.SizeMode = PictureBoxSizeMode.StretchImage;
            mic7.Image = Image.FromFile("stage.jpg");

            next.Height = 100;
            next.Width = 20;
            next.Location = new Point(1420, 530);
            next.BorderStyle = BorderStyle.Fixed3D;


            player.Height = 50;
            player.Width = 60;
            player.Left = 2;
            player.Top =  870;
            player.BorderStyle = BorderStyle.None;
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            player.Image = Image.FromFile("Chara.png");
         

            
            floor.Width = 2010;
            floor.Height = 50;
            floor.Top = player.Top + 55;
            floor.Left = 0;
            floor.BorderStyle = BorderStyle.None;
            floor.SizeMode = PictureBoxSizeMode.StretchImage;
            floor.Image = Image.FromFile("floor.jpg");
            floor.Tag = "g";
           
            bad.Height = 40;
            bad.Width = 50;
            bad.Top = mic2.Top - 40 ; // לפי הגובה של הריבוע mic2 
            bad.Left = mic2.Left + 80;
            bad.SizeMode = PictureBoxSizeMode.StretchImage;
            bad.Image = Image.FromFile("evel.jpg");

            bad1.Height = 40;
            bad1.Width = 50;
            bad1.Top = mic5.Top - 40; // לפי הגובה של הריבוע mic5 
            bad1.Left = mic5.Left + 80;         
            bad1.SizeMode = PictureBoxSizeMode.StretchImage;
            bad1.Image = Image.FromFile("evel.jpg");
            
            this.Controls.Add(player);
            this.Controls.Add(floor);
            this.Controls.Add(bad);
            this.Controls.Add(mic);
            this.Controls.Add(mic1);
            this.Controls.Add(mic2);
            this.Controls.Add(mic3);
            this.Controls.Add(mic4);
            this.Controls.Add(mic5);
            this.Controls.Add(mic6);
            this.Controls.Add(mic7);
            this.Controls.Add(next);
            this.Controls.Add(bad1);
            this.Controls.Add(shoot);

            timer3.Enabled = true;
           


        }

        private void keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) 
            {
                right = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = true;
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close(); //exit
            }


            //MessageBox.Show(e.KeyValue.ToString());

         
            if (e.KeyValue == 32)
            {
                shoot.Location = player.Location;
                timer4.Enabled = true;
            }
           
            if (e.KeyValue == 38 && jumping==true)
            {
                key = 38;
                if (timer1.Enabled == false)
                {
                    timer1.Enabled = true;
                }
                if (key == 38)
                {
                    player.Top -= 100;
                    

                }
                else
                  {
                     timer1.Enabled = false;
                  }


                if (e.KeyValue==38)
                {
                    timer1.Enabled = true;
                }

                jumping = false;
            }
           
            if (right)
            {
                timer2.Enabled = true;
            }
            if (left)
            {
                timer2.Enabled = true;
            }
        }
        private void keyUp(object sender, KeyEventArgs e)
        {

            if (right == true)
            {
                player.Left += 5;
            }
            if (left == true)
            {
                player.Left -= 5;
            }
            if (e.KeyCode == Keys.Right)
            {
                right = false;

            }
            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
          
            
            if (jumping)
            {
                
                jumping = false;

            }
            

           

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (right == true)
            {
               player.Left += 15;
                
            }
            if (left == true)
            {
                player.Left -= 15;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            
            if (!player.Bounds.IntersectsWith(mic.Bounds) && !player.Bounds.IntersectsWith(floor.Bounds) && !player.Bounds.IntersectsWith(mic1.Bounds) && !player.Bounds.IntersectsWith(mic2.Bounds) && !player.Bounds.IntersectsWith(mic3.Bounds) && !player.Bounds.IntersectsWith(mic4.Bounds) && !player.Bounds.IntersectsWith(mic5.Bounds) && !player.Bounds.IntersectsWith(mic6.Bounds) && !player.Bounds.IntersectsWith(mic7.Bounds))
            {
                timer1.Enabled = true;
                jumping = false;
            }

            if (player.Bounds.IntersectsWith(mic.Bounds) || player.Bounds.IntersectsWith(floor.Bounds) || player.Bounds.IntersectsWith(mic1.Bounds) || player.Bounds.IntersectsWith(mic2.Bounds) || player.Bounds.IntersectsWith(mic3.Bounds) || player.Bounds.IntersectsWith(mic4.Bounds) || player.Bounds.IntersectsWith(mic5.Bounds) || player.Bounds.IntersectsWith(mic6.Bounds))

            {
                timer1.Enabled = false;
                jumping = true;
            }

          

          
          if (player.Bounds.IntersectsWith(bad.Bounds) || player.Bounds.IntersectsWith(bad1.Bounds))
          {

                player.Left = 2;
                player.Top = 870;
            }
          if (player.Bounds.IntersectsWith(next.Bounds))
          {
                player.Left = 2;
                player.Top = 870;

                mic.Location = new Point(player.Left + 100, player.Top - 80);
                mic1.Location = new Point(mic.Left+50, mic.Top - 100);
                mic2.Location = new Point(mic1.Left+50, mic1.Top - 100);
                mic3.Location = new Point(mic2.Left+50, mic2.Top - 100);
                mic4.Location = new Point(mic3.Left, mic3.Top - 100);
                mic5.Location = new Point(mic4.Left + 100, mic4.Top - 100);
                mic6.Location = new Point(mic5.Left + 100, mic5.Top - 100);
                mic7.Location = new Point(mic6.Left+150, mic6.Top + 100);
                next.Location = new Point(mic7.Left + 150, mic7.Top -50);


                bad.Top = mic2.Top - 20;
                bad.Left = mic2.Left +100;

                bad1.Top = mic5.Top - 40;
                bad1.Left = mic5.Left + 100;
            }
         


            //if (player.Top == mic2.Bottom)
            //{
            //    timer1.Enabled = true;
            //}


        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            
            shoot.Left += 40;
            
            if (shoot.Bounds.IntersectsWith(bad.Bounds) )
            {
                bad.Location = new Point(3000, 3000);
            }
            if (shoot.Bounds.IntersectsWith(bad1.Bounds))
            {
                bad1.Location = new Point (3000, 3000);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!player.Bounds.IntersectsWith(mic.Bounds) && !player.Bounds.IntersectsWith(floor.Bounds) && !player.Bounds.IntersectsWith(mic1.Bounds) && !player.Bounds.IntersectsWith(mic2.Bounds) && !player.Bounds.IntersectsWith(mic3.Bounds) && !player.Bounds.IntersectsWith(mic4.Bounds) && !player.Bounds.IntersectsWith(mic5.Bounds) && !player.Bounds.IntersectsWith(mic6.Bounds) && !player.Bounds.IntersectsWith(mic7.Bounds))
            {
                jumping = false;

            }

            if (player.Bounds.IntersectsWith(mic.Bounds) || player.Bounds.IntersectsWith(floor.Bounds) || player.Bounds.IntersectsWith(mic1.Bounds) || player.Bounds.IntersectsWith(mic2.Bounds) || player.Bounds.IntersectsWith(mic3.Bounds) || player.Bounds.IntersectsWith(mic4.Bounds) || player.Bounds.IntersectsWith(mic5.Bounds) || player.Bounds.IntersectsWith(mic6.Bounds) || player.Bounds.IntersectsWith(mic7.Bounds))
            {
                timer1.Enabled = false;
                jumping = true;
            }
            if (player.Top != mic.Top || player.Top != mic1.Top || player.Top != mic2.Top || player.Top != mic3.Top || player.Top != mic4.Top || player.Top != mic5.Top || player.Top != mic6.Top || player.Top != mic7.Top)
            {
                player.Top += 10;
                jumping = false;

            }


            if (player.Top >= Screen.PrimaryScreen.Bounds.Height)
                {
                    player.Top = Screen.PrimaryScreen.Bounds.Height;

                jumping = false;
            }

          

                //else
                //{

                //jumping = true;
                //}
           
            //if (jumping && force < 0)
            //{
            //    jumping = false;

            //}
            //if (!jumping)
            //{

            //    player.Top += force;

            //}



            
        }

     
    }

      

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    button1.Location = (this.Location = new Point(MousePosition.X, MousePosition.Y));
        //    button1.Text = (Location = new Point(MousePosition.X, MousePosition.Y)).ToString();
        //}

        }
    







 
       
        

            
        




        


        

    

