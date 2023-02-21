
namespace NewGameGui
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.soldier = new System.Windows.Forms.PictureBox();
            this.GameLoop = new System.Windows.Forms.Timer(this.components);
            this.leftPlatformBig = new System.Windows.Forms.PictureBox();
            this.middlePlatformSmall = new System.Windows.Forms.PictureBox();
            this.rightPlatformLong = new System.Windows.Forms.PictureBox();
            this.rightPlatformBig = new System.Windows.Forms.PictureBox();
            this.soldierHealth = new System.Windows.Forms.ProgressBar();
            this.purpleDragonHealth = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.MovementTimer = new System.Windows.Forms.Timer(this.components);
            this.middleLongPlatform = new System.Windows.Forms.PictureBox();
            this.ladderBig = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.soldier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPlatformBig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.middlePlatformSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPlatformLong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPlatformBig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleLongPlatform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladderBig)).BeginInit();
            this.SuspendLayout();
            // 
            // soldier
            // 
            this.soldier.BackColor = System.Drawing.Color.Transparent;
            this.soldier.Image = global::NewGameGui.Properties.Resources.newStandStraight;
            this.soldier.Location = new System.Drawing.Point(27, 659);
            this.soldier.Name = "soldier";
            this.soldier.Size = new System.Drawing.Size(75, 100);
            this.soldier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.soldier.TabIndex = 0;
            this.soldier.TabStop = false;
            // 
            // GameLoop
            // 
            this.GameLoop.Enabled = true;
            this.GameLoop.Interval = 50;
            this.GameLoop.Tick += new System.EventHandler(this.GameLoop_Tick);
            // 
            // leftPlatformBig
            // 
            this.leftPlatformBig.BackColor = System.Drawing.Color.Transparent;
            this.leftPlatformBig.Image = global::NewGameGui.Properties.Resources.BigPlatform1;
            this.leftPlatformBig.Location = new System.Drawing.Point(-4, 435);
            this.leftPlatformBig.Name = "leftPlatformBig";
            this.leftPlatformBig.Size = new System.Drawing.Size(321, 73);
            this.leftPlatformBig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.leftPlatformBig.TabIndex = 1;
            this.leftPlatformBig.TabStop = false;
            this.leftPlatformBig.Tag = "platform";
            this.leftPlatformBig.Click += new System.EventHandler(this.leftPlatformBig_Click);
            // 
            // middlePlatformSmall
            // 
            this.middlePlatformSmall.BackColor = System.Drawing.Color.Transparent;
            this.middlePlatformSmall.Image = global::NewGameGui.Properties.Resources.SmallPlatform1;
            this.middlePlatformSmall.Location = new System.Drawing.Point(445, 191);
            this.middlePlatformSmall.Name = "middlePlatformSmall";
            this.middlePlatformSmall.Size = new System.Drawing.Size(163, 59);
            this.middlePlatformSmall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.middlePlatformSmall.TabIndex = 2;
            this.middlePlatformSmall.TabStop = false;
            this.middlePlatformSmall.Tag = "platform";
            // 
            // rightPlatformLong
            // 
            this.rightPlatformLong.BackColor = System.Drawing.Color.Transparent;
            this.rightPlatformLong.Image = global::NewGameGui.Properties.Resources.longPlatform;
            this.rightPlatformLong.Location = new System.Drawing.Point(838, 288);
            this.rightPlatformLong.Name = "rightPlatformLong";
            this.rightPlatformLong.Size = new System.Drawing.Size(911, 73);
            this.rightPlatformLong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rightPlatformLong.TabIndex = 3;
            this.rightPlatformLong.TabStop = false;
            this.rightPlatformLong.Tag = "platform";
            // 
            // rightPlatformBig
            // 
            this.rightPlatformBig.BackColor = System.Drawing.Color.Transparent;
            this.rightPlatformBig.Image = global::NewGameGui.Properties.Resources.BigPlatform1;
            this.rightPlatformBig.Location = new System.Drawing.Point(1584, 626);
            this.rightPlatformBig.Name = "rightPlatformBig";
            this.rightPlatformBig.Size = new System.Drawing.Size(321, 73);
            this.rightPlatformBig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rightPlatformBig.TabIndex = 4;
            this.rightPlatformBig.TabStop = false;
            this.rightPlatformBig.Tag = "platform";
            // 
            // soldierHealth
            // 
            this.soldierHealth.ForeColor = System.Drawing.Color.Green;
            this.soldierHealth.Location = new System.Drawing.Point(16, 639);
            this.soldierHealth.Name = "soldierHealth";
            this.soldierHealth.Size = new System.Drawing.Size(103, 14);
            this.soldierHealth.TabIndex = 5;
            this.soldierHealth.Value = 100;
            // 
            // purpleDragonHealth
            // 
            this.purpleDragonHealth.ForeColor = System.Drawing.Color.Green;
            this.purpleDragonHealth.Location = new System.Drawing.Point(790, 12);
            this.purpleDragonHealth.Name = "purpleDragonHealth";
            this.purpleDragonHealth.Size = new System.Drawing.Size(128, 23);
            this.purpleDragonHealth.TabIndex = 7;
            this.purpleDragonHealth.Value = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(613, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Purple Dragon Health";
            // 
            // MovementTimer
            // 
            this.MovementTimer.Enabled = true;
            this.MovementTimer.Interval = 300;
            this.MovementTimer.Tick += new System.EventHandler(this.MovementTimer_Tick);
            // 
            // middleLongPlatform
            // 
            this.middleLongPlatform.BackColor = System.Drawing.Color.Transparent;
            this.middleLongPlatform.Image = global::NewGameGui.Properties.Resources.longPlatform;
            this.middleLongPlatform.Location = new System.Drawing.Point(391, 626);
            this.middleLongPlatform.Name = "middleLongPlatform";
            this.middleLongPlatform.Size = new System.Drawing.Size(911, 73);
            this.middleLongPlatform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.middleLongPlatform.TabIndex = 9;
            this.middleLongPlatform.TabStop = false;
            this.middleLongPlatform.Tag = "platform";
            // 
            // ladderBig
            // 
            this.ladderBig.BackColor = System.Drawing.Color.Transparent;
            this.ladderBig.Image = global::NewGameGui.Properties.Resources.ladder;
            this.ladderBig.Location = new System.Drawing.Point(617, 684);
            this.ladderBig.Name = "ladderBig";
            this.ladderBig.Size = new System.Drawing.Size(44, 194);
            this.ladderBig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ladderBig.TabIndex = 10;
            this.ladderBig.TabStop = false;
            this.ladderBig.Tag = "platform";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NewGameGui.Properties.Resources.swamp_game_background_dark_landscape_tileable_horizontally_dead_trees_fog_stones_plants_49998146;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1672, 767);
            this.Controls.Add(this.ladderBig);
            this.Controls.Add(this.middleLongPlatform);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.purpleDragonHealth);
            this.Controls.Add(this.soldierHealth);
            this.Controls.Add(this.rightPlatformBig);
            this.Controls.Add(this.rightPlatformLong);
            this.Controls.Add(this.middlePlatformSmall);
            this.Controls.Add(this.leftPlatformBig);
            this.Controls.Add(this.soldier);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Tag = "platform";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Enter += new System.EventHandler(this.Form1_Enter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.soldier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPlatformBig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.middlePlatformSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPlatformLong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPlatformBig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleLongPlatform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladderBig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox soldier;
        private System.Windows.Forms.Timer GameLoop;
        private System.Windows.Forms.PictureBox leftPlatformBig;
        private System.Windows.Forms.PictureBox middlePlatformSmall;
        private System.Windows.Forms.PictureBox rightPlatformLong;
        private System.Windows.Forms.PictureBox rightPlatformBig;
        private System.Windows.Forms.ProgressBar soldierHealth;
        private System.Windows.Forms.ProgressBar purpleDragonHealth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer MovementTimer;
        private System.Windows.Forms.PictureBox middleLongPlatform;
        private System.Windows.Forms.PictureBox ladderBig;
    }
}

