using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZInput;

namespace NewGameGui
{
    public partial class Form1 : Form
    {
        List<PictureBox> soldierFireList = new List<PictureBox>();
        List<PictureBox> purpleDragonFire = new List<PictureBox>();
        List<PictureBox> purpleDragonFire2 = new List<PictureBox>();
        List<PictureBox> purpleDragonFire3 = new List<PictureBox>();
        List<PictureBox> EnemyFireTowardLeftList = new List<PictureBox>();
        List<PictureBox> enemyList = new List<PictureBox>();
        Random rand = new Random();
        PictureBox dragonPurple = new PictureBox();
        PictureBox dragonPurple2 = new PictureBox();
        PictureBox dragonPurple3 = new PictureBox();
        bool firedirection = true;
        string dragonPurpleDirection = "MoveLeft";
        string dragonPurpleDirection2 = "MoveRight";
        string dragonPurpleDirection3 = "MoveLeft";
        int purpleDragonLastTimeFire = 0;
        int purpleDragonToFire = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void GameLoop_Tick(object sender, EventArgs e)
        {
            
            if(Keyboard.IsKeyPressed(Key.RightArrow) && soldier.Left<1427)
            {
                soldier.Image = Properties.Resources.newStandStraight;
                soldier.Left = soldier.Left + 10;
                soldierHealth.Left = soldierHealth.Left + 10;
                soldier.Tag = "Right";
                firedirection = true;
            }
            if (Keyboard.IsKeyPressed(Key.LeftArrow) && soldier.Left>0 && soldierHealth.Left>0)
            {
                soldier.Image = Properties.Resources.NewOppositStraight;
                soldier.Left = soldier.Left - 10;
                soldierHealth.Left = soldierHealth.Left - 10;
                firedirection = false;
            }
            if (Keyboard.IsKeyPressed(Key.UpArrow) && soldier.Top>0 && soldierHealth.Top>0)
            {
                soldier.Top = soldier.Top - 25;
                soldierHealth.Top = soldierHealth.Top - 25;
            }
            if (soldier.Top + soldier.Width < 800 && soldierHealth.Top + soldierHealth.Width < 800)
            {
                soldier.Top += 8;
                soldierHealth.Top = soldierHealth.Top + 8;
            }
            if (Keyboard.IsKeyPressed(Key.Space))
            {
               
               if(firedirection == true)
               {

                    soldierFire("Right");
               }
               else
                {
                    soldierFire("Left");
                }               
            }
            foreach (Control platfrom in this.Controls)
            {
                if (platfrom is PictureBox && (string)platfrom.Tag == "platform")
                {
                    if (soldier.Bounds.IntersectsWith(platfrom.Bounds))
                    {
                        soldier.Top = platfrom.Top - soldier.Height;
                        soldierHealth.Top = soldier.Top - soldierHealth.Height;
                        /*check = true;*/
                    }
                }
                
                soldier.BringToFront();
            }
            foreach (Control platfrom in this.Controls)
            {
                foreach (var item in enemyList)
                {


                    if (platfrom is PictureBox && (string)platfrom.Tag == "platform")
                    {
                        if (item.Bounds.IntersectsWith(platfrom.Bounds))
                        {
                            item.Top = platfrom.Top - item.Height;
                            /*check = true;*/
                        }
                    }
                    item.BringToFront();
                }

                
            }
            if(dragonPurple.Top<1400)
            {
                dragonPurple.Top += 8;
            }
            {

            }
            foreach (PictureBox bullet in soldierFireList)
            {
                if((string)bullet.Tag == "Right")
                {

                    bullet.Left = bullet.Left + 15;
                }
                else if((string)bullet.Tag == "Left")
                {
                    bullet.Left -= 15;
                }

            }

            foreach (var fire in purpleDragonFire)
            {
                if ((string)fire.Tag == "MoveRight")
                {

                    fire.Left = fire.Left + 15;
                }
                else if ((string)fire.Tag == "MoveLeft")
                {
                    fire.Left -= 15;
                }

            }
           /* foreach (var fire in purpleDragonFire2)
            {
                if ((string)fire.Tag == "MoveRight")
                {

                    fire.Left = fire.Left + 15;
                }
                else if ((string)fire.Tag == "MoveLeft")
                {
                    fire.Left -= 15;
                }

            }
            foreach (var fire in purpleDragonFire3)
            {
                if ((string)fire.Tag == "MoveRight")
                {

                    fire.Left = fire.Left + 15;
                }
                else if ((string)fire.Tag == "MoveLeft")
                {
                    fire.Left -= 15;
                }

            }*/
            for (int i = 0; i < purpleDragonFire.Count; i++)
            {
                if(purpleDragonFire[i].Left>this.Width)
                {
                    purpleDragonFire.RemoveAt(i);
           
                    
                }

            }
         
            foreach (PictureBox bullet in soldierFireList)
            {
                if(bullet.Bounds.IntersectsWith(dragonPurple.Bounds))
                {
                    if(purpleDragonHealth.Value>0)
                    {
                        purpleDragonHealth.Value = purpleDragonHealth.Value - 1;
                    }
                }
            }
            foreach (PictureBox bullet in purpleDragonFire)
            {
                if (bullet.Bounds.IntersectsWith(soldier.Bounds))
                {
                    if (soldierHealth.Value > 0)
                    {
                        soldierHealth.Value = soldierHealth.Value - 1;
                    }
                }
            }
            


        }
        private void MovementTimer_Tick(object sender, EventArgs e)
        {
            moveEnemy(dragonPurple, ref dragonPurpleDirection);
            moveEnemy(dragonPurple2, ref dragonPurpleDirection2);
            moveEnemy(dragonPurple3, ref dragonPurpleDirection3);

            purpleDragonLastTimeFire++;
            if (purpleDragonLastTimeFire >= purpleDragonToFire)
            {
                Image fireImage = Properties.Resources.NewFire;
                PictureBox pbFire = createEnemyFire(fireImage, dragonPurple, dragonPurpleDirection);
                /*PictureBox pbFire2 = createEnemyFire(fireImage, dragonPurple2, dragonPurpleDirection2);
                PictureBox pbFire3 = createEnemyFire(fireImage, dragonPurple2, dragonPurpleDirection2);*/
                /*purpleDragonFire3.Add(pbFire3);
                purpleDragonFire2.Add(pbFire2);*/
                purpleDragonFire.Add(pbFire);
                this.Controls.Add(pbFire);
                /*this.Controls.Add(pbFire2);
                this.Controls.Add(pbFire3);*/
                purpleDragonLastTimeFire = 0;
            }


        }
        //Time Tick End........

        private void soldierFire(string direction)
        {
            PictureBox soldierFire = new PictureBox();
            Image fireImage = Properties.Resources.soldierFire2;
            soldierFire.Image = fireImage;
            soldierFire.Width = fireImage.Width;
            soldierFire.Height = fireImage.Height;
            soldierFire.BackColor = Color.Transparent;
            System.Drawing.Point fireLocation = new System.Drawing.Point();
            fireLocation.X = soldier.Left + (soldier.Width / 2) - 5;
            fireLocation.Y = soldier.Top+30;
            soldierFire.Location = fireLocation;
            soldierFire.Tag = direction;
            soldierFireList.Add(soldierFire);
            this.Controls.Add(soldierFire);
            
        }

      
        private PictureBox createEnemy(Image img,string enemyType)
        {
            PictureBox pbEnemy = new PictureBox();
            int left = rand.Next(100, this.Width);
            int top = rand.Next(5, img.Height + 5);
            pbEnemy.Left = Left;
            pbEnemy.Top = 232;
            pbEnemy.Height = img.Height;
            pbEnemy.Width = img.Width;
            pbEnemy.Tag = enemyType;
            pbEnemy.BackColor = Color.Transparent;
            pbEnemy.Image = img;
            return pbEnemy;

        }

        private void moveEnemy(PictureBox enemy,ref string enemyDirection)
        {
            if(enemyDirection=="MoveRight")
            {
               
               
                enemy.Left = enemy.Left + 15;
            }
            if (enemyDirection == "MoveLeft")
            {
               
                enemy.Left = enemy.Left - 15;
            }
            if(enemy.Left+enemy.Width>this.Width)
            {
                dragonPurple.Image.Dispose();
                dragonPurple.Image = null;
                dragonPurple.Image = Properties.Resources.NewPurpleDragonTowardLeft;
                enemyDirection = "MoveLeft";
            }
            if(enemy.Left<=2)
            {
                dragonPurple.Image.Dispose();
                dragonPurple.Image = null;
                dragonPurple.Image = Properties.Resources.NewPurpleDragonTowardRight;
                enemyDirection = "MoveRight";
            }
        }
        private PictureBox createEnemyFire(Image fireImage,PictureBox Source,string direction)
        {
            PictureBox pbFire = new PictureBox();
            pbFire.Image = fireImage;
            pbFire.Width = fireImage.Width;
            pbFire.Height = fireImage.Height;
            pbFire.BackColor = Color.Transparent;
            System.Drawing.Point fireLocation = new System.Drawing.Point();
            fireLocation.X = Source.Left + (Source.Width / 2) - 5;
            fireLocation.Y = Source.Top +35;
            pbFire.Tag = direction;
            pbFire.Location = fireLocation;
            return pbFire;


        }
        private void Form1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Escape)
            {
                this.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            dragonPurple = createEnemy(Properties.Resources.NewPurpleDragonTowardRight, "enemy");
            /*dragonPurple2 = createEnemy2(Properties.Resources.NewPurpleDragonTowardRight, "enemy");
            dragonPurple3 = createEnemy(Properties.Resources.NewPurpleDragonTowardRight, "enemy");*/
            enemyList.Add(dragonPurple);
            /*enemyList.Add(dragonPurple2);
            enemyList.Add(dragonPurple3);*/
            this.Controls.Add(dragonPurple);
            /*this.Controls.Add(dragonPurple2);
            this.Controls.Add(dragonPurple3);*/

        }

        private void leftPlatformBig_Click(object sender, EventArgs e)
        {

        }
    }
}
