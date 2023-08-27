using System.Drawing;
using System.Windows.Forms;

namespace OAnQuan
{
    partial class FrmPlay
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
            this.lblMarkOfComputer = new System.Windows.Forms.Label();
            this.lblMarkOfYou = new System.Windows.Forms.Label();
            this.lblNotice = new System.Windows.Forms.Label();
            this.flpYou1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpYou2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpYou3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpYou4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpYou5 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpMandarin1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpComputer5 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpComputer4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpComputer3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpComputer2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpComputer1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpMandarin2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEasyMode = new System.Windows.Forms.Button();
            this.lblResultOfComputer = new System.Windows.Forms.Label();
            this.lblResultOfYou = new System.Windows.Forms.Label();
            this.btnLeft1 = new System.Windows.Forms.Button();
            this.btnLeft2 = new System.Windows.Forms.Button();
            this.btnRight2 = new System.Windows.Forms.Button();
            this.btnLeft3 = new System.Windows.Forms.Button();
            this.btnRight3 = new System.Windows.Forms.Button();
            this.btnLeft4 = new System.Windows.Forms.Button();
            this.btnRight4 = new System.Windows.Forms.Button();
            this.btnLeft5 = new System.Windows.Forms.Button();
            this.btnRight5 = new System.Windows.Forms.Button();
            this.btnRight1 = new System.Windows.Forms.Button();
            this.lblTrue = new System.Windows.Forms.Label();
            this.lblComputerDirection = new System.Windows.Forms.Label();
            this.btnReplay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuReplay = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGuide = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHardMode = new System.Windows.Forms.Button();
            this.lblMode = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMarkOfComputer
            // 
            this.lblMarkOfComputer.AutoSize = true;
            this.lblMarkOfComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarkOfComputer.Location = new System.Drawing.Point(691, 57);
            this.lblMarkOfComputer.Name = "lblMarkOfComputer";
            this.lblMarkOfComputer.Size = new System.Drawing.Size(183, 29);
            this.lblMarkOfComputer.TabIndex = 15;
            this.lblMarkOfComputer.Text = "Điểm của Máy:";
            // 
            // lblMarkOfYou
            // 
            this.lblMarkOfYou.AutoSize = true;
            this.lblMarkOfYou.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarkOfYou.Location = new System.Drawing.Point(691, 460);
            this.lblMarkOfYou.Name = "lblMarkOfYou";
            this.lblMarkOfYou.Size = new System.Drawing.Size(180, 29);
            this.lblMarkOfYou.TabIndex = 16;
            this.lblMarkOfYou.Text = "Điểm của Bạn:";
            // 
            // lblNotice
            // 
            this.lblNotice.AutoSize = true;
            this.lblNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotice.Location = new System.Drawing.Point(396, 223);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(237, 39);
            this.lblNotice.TabIndex = 19;
            this.lblNotice.Text = "Đến lượt bạn!!!";
            this.lblNotice.Visible = false;
            // 
            // flpYou1
            // 
            this.flpYou1.BackColor = System.Drawing.Color.Blue;
            this.flpYou1.Location = new System.Drawing.Point(154, 248);
            this.flpYou1.Name = "flpYou1";
            this.flpYou1.Size = new System.Drawing.Size(132, 132);
            this.flpYou1.TabIndex = 24;
            // 
            // flpYou2
            // 
            this.flpYou2.BackColor = System.Drawing.Color.Blue;
            this.flpYou2.Location = new System.Drawing.Point(292, 248);
            this.flpYou2.Name = "flpYou2";
            this.flpYou2.Size = new System.Drawing.Size(132, 132);
            this.flpYou2.TabIndex = 25;
            // 
            // flpYou3
            // 
            this.flpYou3.BackColor = System.Drawing.Color.Blue;
            this.flpYou3.Location = new System.Drawing.Point(432, 248);
            this.flpYou3.Name = "flpYou3";
            this.flpYou3.Size = new System.Drawing.Size(132, 132);
            this.flpYou3.TabIndex = 25;
            // 
            // flpYou4
            // 
            this.flpYou4.BackColor = System.Drawing.Color.Blue;
            this.flpYou4.Location = new System.Drawing.Point(570, 248);
            this.flpYou4.Name = "flpYou4";
            this.flpYou4.Size = new System.Drawing.Size(132, 132);
            this.flpYou4.TabIndex = 25;
            // 
            // flpYou5
            // 
            this.flpYou5.BackColor = System.Drawing.Color.Blue;
            this.flpYou5.Location = new System.Drawing.Point(708, 248);
            this.flpYou5.Name = "flpYou5";
            this.flpYou5.Size = new System.Drawing.Size(132, 132);
            this.flpYou5.TabIndex = 25;
            // 
            // flpMandarin1
            // 
            this.flpMandarin1.BackColor = System.Drawing.Color.Tomato;
            this.flpMandarin1.Location = new System.Drawing.Point(846, 153);
            this.flpMandarin1.Name = "flpMandarin1";
            this.flpMandarin1.Size = new System.Drawing.Size(132, 202);
            this.flpMandarin1.TabIndex = 25;
            // 
            // flpComputer5
            // 
            this.flpComputer5.BackColor = System.Drawing.Color.Green;
            this.flpComputer5.Location = new System.Drawing.Point(708, 110);
            this.flpComputer5.Name = "flpComputer5";
            this.flpComputer5.Size = new System.Drawing.Size(132, 132);
            this.flpComputer5.TabIndex = 25;
            // 
            // flpComputer4
            // 
            this.flpComputer4.BackColor = System.Drawing.Color.Green;
            this.flpComputer4.Location = new System.Drawing.Point(570, 110);
            this.flpComputer4.Name = "flpComputer4";
            this.flpComputer4.Size = new System.Drawing.Size(132, 132);
            this.flpComputer4.TabIndex = 25;
            // 
            // flpComputer3
            // 
            this.flpComputer3.BackColor = System.Drawing.Color.Green;
            this.flpComputer3.Location = new System.Drawing.Point(432, 110);
            this.flpComputer3.Name = "flpComputer3";
            this.flpComputer3.Size = new System.Drawing.Size(132, 132);
            this.flpComputer3.TabIndex = 25;
            // 
            // flpComputer2
            // 
            this.flpComputer2.BackColor = System.Drawing.Color.Green;
            this.flpComputer2.Location = new System.Drawing.Point(292, 110);
            this.flpComputer2.Name = "flpComputer2";
            this.flpComputer2.Size = new System.Drawing.Size(132, 132);
            this.flpComputer2.TabIndex = 25;
            // 
            // flpComputer1
            // 
            this.flpComputer1.BackColor = System.Drawing.Color.Green;
            this.flpComputer1.Location = new System.Drawing.Point(154, 110);
            this.flpComputer1.Name = "flpComputer1";
            this.flpComputer1.Size = new System.Drawing.Size(132, 132);
            this.flpComputer1.TabIndex = 25;
            // 
            // flpMandarin2
            // 
            this.flpMandarin2.BackColor = System.Drawing.Color.Tomato;
            this.flpMandarin2.Location = new System.Drawing.Point(16, 153);
            this.flpMandarin2.Name = "flpMandarin2";
            this.flpMandarin2.Size = new System.Drawing.Size(132, 202);
            this.flpMandarin2.TabIndex = 26;
            // 
            // btnEasyMode
            // 
            this.btnEasyMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEasyMode.Location = new System.Drawing.Point(260, 47);
            this.btnEasyMode.Name = "btnEasyMode";
            this.btnEasyMode.Size = new System.Drawing.Size(156, 62);
            this.btnEasyMode.TabIndex = 27;
            this.btnEasyMode.Text = "Dễ";
            this.btnEasyMode.UseVisualStyleBackColor = true;
            this.btnEasyMode.Click += new System.EventHandler(this.btnEasyMode_Click);
            // 
            // lblResultOfComputer
            // 
            this.lblResultOfComputer.AutoSize = true;
            this.lblResultOfComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultOfComputer.Location = new System.Drawing.Point(880, 47);
            this.lblResultOfComputer.Name = "lblResultOfComputer";
            this.lblResultOfComputer.Size = new System.Drawing.Size(36, 39);
            this.lblResultOfComputer.TabIndex = 28;
            this.lblResultOfComputer.Text = "0";
            // 
            // lblResultOfYou
            // 
            this.lblResultOfYou.AutoSize = true;
            this.lblResultOfYou.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultOfYou.Location = new System.Drawing.Point(880, 450);
            this.lblResultOfYou.Name = "lblResultOfYou";
            this.lblResultOfYou.Size = new System.Drawing.Size(36, 39);
            this.lblResultOfYou.TabIndex = 29;
            this.lblResultOfYou.Text = "0";
            // 
            // btnLeft1
            // 
            this.btnLeft1.Enabled = false;
            this.btnLeft1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft1.Location = new System.Drawing.Point(172, 386);
            this.btnLeft1.Name = "btnLeft1";
            this.btnLeft1.Size = new System.Drawing.Size(95, 23);
            this.btnLeft1.TabIndex = 31;
            this.btnLeft1.Text = "<------";
            this.btnLeft1.UseVisualStyleBackColor = true;
            this.btnLeft1.Click += new System.EventHandler(this.btnLeft1_Click);
            // 
            // btnLeft2
            // 
            this.btnLeft2.Enabled = false;
            this.btnLeft2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft2.Location = new System.Drawing.Point(308, 386);
            this.btnLeft2.Name = "btnLeft2";
            this.btnLeft2.Size = new System.Drawing.Size(95, 23);
            this.btnLeft2.TabIndex = 32;
            this.btnLeft2.Text = "<------";
            this.btnLeft2.UseVisualStyleBackColor = true;
            this.btnLeft2.Click += new System.EventHandler(this.btnLeft1_Click);
            // 
            // btnRight2
            // 
            this.btnRight2.Enabled = false;
            this.btnRight2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight2.Location = new System.Drawing.Point(308, 415);
            this.btnRight2.Name = "btnRight2";
            this.btnRight2.Size = new System.Drawing.Size(95, 23);
            this.btnRight2.TabIndex = 33;
            this.btnRight2.Text = "------>";
            this.btnRight2.UseVisualStyleBackColor = true;
            this.btnRight2.Click += new System.EventHandler(this.btnRight1_Click);
            // 
            // btnLeft3
            // 
            this.btnLeft3.Enabled = false;
            this.btnLeft3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft3.Location = new System.Drawing.Point(449, 386);
            this.btnLeft3.Name = "btnLeft3";
            this.btnLeft3.Size = new System.Drawing.Size(95, 23);
            this.btnLeft3.TabIndex = 34;
            this.btnLeft3.Text = "<------";
            this.btnLeft3.UseVisualStyleBackColor = true;
            this.btnLeft3.Click += new System.EventHandler(this.btnLeft1_Click);
            // 
            // btnRight3
            // 
            this.btnRight3.Enabled = false;
            this.btnRight3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight3.Location = new System.Drawing.Point(449, 415);
            this.btnRight3.Name = "btnRight3";
            this.btnRight3.Size = new System.Drawing.Size(95, 23);
            this.btnRight3.TabIndex = 35;
            this.btnRight3.Text = "------>";
            this.btnRight3.UseVisualStyleBackColor = true;
            this.btnRight3.Click += new System.EventHandler(this.btnRight1_Click);
            // 
            // btnLeft4
            // 
            this.btnLeft4.Enabled = false;
            this.btnLeft4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft4.Location = new System.Drawing.Point(585, 386);
            this.btnLeft4.Name = "btnLeft4";
            this.btnLeft4.Size = new System.Drawing.Size(95, 23);
            this.btnLeft4.TabIndex = 36;
            this.btnLeft4.Text = "<------";
            this.btnLeft4.UseVisualStyleBackColor = true;
            this.btnLeft4.Click += new System.EventHandler(this.btnLeft1_Click);
            // 
            // btnRight4
            // 
            this.btnRight4.Enabled = false;
            this.btnRight4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight4.Location = new System.Drawing.Point(585, 415);
            this.btnRight4.Name = "btnRight4";
            this.btnRight4.Size = new System.Drawing.Size(95, 23);
            this.btnRight4.TabIndex = 37;
            this.btnRight4.Text = "------>";
            this.btnRight4.UseVisualStyleBackColor = true;
            this.btnRight4.Click += new System.EventHandler(this.btnRight1_Click);
            // 
            // btnLeft5
            // 
            this.btnLeft5.Enabled = false;
            this.btnLeft5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft5.Location = new System.Drawing.Point(728, 386);
            this.btnLeft5.Name = "btnLeft5";
            this.btnLeft5.Size = new System.Drawing.Size(95, 23);
            this.btnLeft5.TabIndex = 38;
            this.btnLeft5.Text = "<------";
            this.btnLeft5.UseVisualStyleBackColor = true;
            this.btnLeft5.Click += new System.EventHandler(this.btnLeft1_Click);
            // 
            // btnRight5
            // 
            this.btnRight5.Enabled = false;
            this.btnRight5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight5.Location = new System.Drawing.Point(728, 415);
            this.btnRight5.Name = "btnRight5";
            this.btnRight5.Size = new System.Drawing.Size(95, 23);
            this.btnRight5.TabIndex = 39;
            this.btnRight5.Text = "------>";
            this.btnRight5.UseVisualStyleBackColor = true;
            this.btnRight5.Click += new System.EventHandler(this.btnRight1_Click);
            // 
            // btnRight1
            // 
            this.btnRight1.Enabled = false;
            this.btnRight1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight1.Location = new System.Drawing.Point(172, 415);
            this.btnRight1.Name = "btnRight1";
            this.btnRight1.Size = new System.Drawing.Size(95, 23);
            this.btnRight1.TabIndex = 32;
            this.btnRight1.Text = "------>";
            this.btnRight1.UseVisualStyleBackColor = true;
            this.btnRight1.Click += new System.EventHandler(this.btnRight1_Click);
            // 
            // lblTrue
            // 
            this.lblTrue.AutoSize = true;
            this.lblTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrue.Location = new System.Drawing.Point(442, 223);
            this.lblTrue.Name = "lblTrue";
            this.lblTrue.Size = new System.Drawing.Size(106, 39);
            this.lblTrue.TabIndex = 42;
            this.lblTrue.Text = "Ăn rồi";
            this.lblTrue.Visible = false;
            // 
            // lblComputerDirection
            // 
            this.lblComputerDirection.AutoSize = true;
            this.lblComputerDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerDirection.Location = new System.Drawing.Point(473, 66);
            this.lblComputerDirection.Name = "lblComputerDirection";
            this.lblComputerDirection.Size = new System.Drawing.Size(53, 20);
            this.lblComputerDirection.TabIndex = 43;
            this.lblComputerDirection.Text = "label1";
            this.lblComputerDirection.Visible = false;
            // 
            // btnReplay
            // 
            this.btnReplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplay.Location = new System.Drawing.Point(193, 217);
            this.btnReplay.Name = "btnReplay";
            this.btnReplay.Size = new System.Drawing.Size(210, 64);
            this.btnReplay.TabIndex = 44;
            this.btnReplay.Text = "Chơi lại";
            this.btnReplay.UseVisualStyleBackColor = true;
            this.btnReplay.Visible = false;
            this.btnReplay.Click += new System.EventHandler(this.btnReplay_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(585, 210);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(210, 64);
            this.btnExit.TabIndex = 45;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReplay,
            this.mnuGuide});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(993, 30);
            this.menuStrip1.TabIndex = 46;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuReplay
            // 
            this.mnuReplay.Name = "mnuReplay";
            this.mnuReplay.Size = new System.Drawing.Size(73, 26);
            this.mnuReplay.Text = "Chơi lại";
            this.mnuReplay.Click += new System.EventHandler(this.mnuReplay_Click);
            // 
            // mnuGuide
            // 
            this.mnuGuide.Name = "mnuGuide";
            this.mnuGuide.Size = new System.Drawing.Size(87, 26);
            this.mnuGuide.Text = "Cách chơi";
            this.mnuGuide.Click += new System.EventHandler(this.mnuGuide_Click);
            // 
            // btnHardMode
            // 
            this.btnHardMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHardMode.Location = new System.Drawing.Point(422, 47);
            this.btnHardMode.Name = "btnHardMode";
            this.btnHardMode.Size = new System.Drawing.Size(142, 62);
            this.btnHardMode.TabIndex = 47;
            this.btnHardMode.Text = "Khó";
            this.btnHardMode.UseVisualStyleBackColor = true;
            this.btnHardMode.Click += new System.EventHandler(this.btnHardMode_Click);
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.Location = new System.Drawing.Point(22, 66);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(210, 39);
            this.lblMode.TabIndex = 48;
            this.lblMode.Text = "Chọn chế độ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::OAnQuan.Properties.Resources.TRO_CHOI_DAN_GIAN_jpg;
            this.pictureBox1.Location = new System.Drawing.Point(0, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(993, 482);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 512);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.btnHardMode);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReplay);
            this.Controls.Add(this.lblComputerDirection);
            this.Controls.Add(this.lblTrue);
            this.Controls.Add(this.lblNotice);
            this.Controls.Add(this.flpYou3);
            this.Controls.Add(this.flpComputer5);
            this.Controls.Add(this.flpComputer4);
            this.Controls.Add(this.flpComputer3);
            this.Controls.Add(this.flpComputer1);
            this.Controls.Add(this.flpComputer2);
            this.Controls.Add(this.flpYou5);
            this.Controls.Add(this.flpYou4);
            this.Controls.Add(this.flpYou2);
            this.Controls.Add(this.flpYou1);
            this.Controls.Add(this.btnRight5);
            this.Controls.Add(this.btnLeft5);
            this.Controls.Add(this.btnRight4);
            this.Controls.Add(this.btnLeft4);
            this.Controls.Add(this.btnRight3);
            this.Controls.Add(this.btnLeft3);
            this.Controls.Add(this.btnRight2);
            this.Controls.Add(this.btnLeft2);
            this.Controls.Add(this.btnRight1);
            this.Controls.Add(this.btnLeft1);
            this.Controls.Add(this.lblResultOfYou);
            this.Controls.Add(this.lblResultOfComputer);
            this.Controls.Add(this.btnEasyMode);
            this.Controls.Add(this.flpMandarin2);
            this.Controls.Add(this.flpMandarin1);
            this.Controls.Add(this.lblMarkOfYou);
            this.Controls.Add(this.lblMarkOfComputer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPlay";
            this.Text = "Play - Nguyễn Đặng Hữu 20206147";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMarkOfComputer;
        private System.Windows.Forms.Label lblMarkOfYou;
        private System.Windows.Forms.Label lblNotice;
        private System.Windows.Forms.FlowLayoutPanel flpYou1;
        private System.Windows.Forms.FlowLayoutPanel flpYou2;
        private System.Windows.Forms.FlowLayoutPanel flpYou3;
        private System.Windows.Forms.FlowLayoutPanel flpYou4;
        private System.Windows.Forms.FlowLayoutPanel flpYou5;
        private System.Windows.Forms.FlowLayoutPanel flpMandarin1;
        private System.Windows.Forms.FlowLayoutPanel flpComputer5;
        private System.Windows.Forms.FlowLayoutPanel flpComputer4;
        private System.Windows.Forms.FlowLayoutPanel flpComputer3;
        private System.Windows.Forms.FlowLayoutPanel flpComputer2;
        private System.Windows.Forms.FlowLayoutPanel flpComputer1;
        private System.Windows.Forms.FlowLayoutPanel flpMandarin2;
        private System.Windows.Forms.Button btnEasyMode;
        private System.Windows.Forms.Label lblResultOfComputer;
        private System.Windows.Forms.Label lblResultOfYou;
        private System.Windows.Forms.Button btnLeft1;
        private System.Windows.Forms.Button btnLeft2;
        private System.Windows.Forms.Button btnRight2;
        private System.Windows.Forms.Button btnLeft3;
        private System.Windows.Forms.Button btnRight3;
        private System.Windows.Forms.Button btnLeft4;
        private System.Windows.Forms.Button btnRight4;
        private System.Windows.Forms.Button btnLeft5;
        private System.Windows.Forms.Button btnRight5;
        private System.Windows.Forms.Button btnRight1;
        private System.Windows.Forms.Label lblTrue;
        private Label lblComputerDirection;
        private Button btnReplay;
        private Button btnExit;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuReplay;
        private ToolStripMenuItem mnuGuide;
        private Button btnHardMode;
        private Label lblMode;
    }
}