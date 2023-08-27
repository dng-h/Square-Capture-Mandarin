using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Configuration;
using System.Collections;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.IO;
using System.Media;

namespace OAnQuan
{
    public partial class FrmPlay : Form
    {
        MarkOfPerson markOfPlayer = new MarkOfPerson();
        MarkOfComputer markOfComputer = new MarkOfComputer();
        string Mode = "";
        int[] amountEachSquare = new int[12];
        string direction = "";
        int turn = 1;
        int square = 0, nextSquare, laterSquare;
        bool quan1 = true;
        bool quan2 = true;
        List<FlowLayoutPanel> lstSquare = new List<FlowLayoutPanel>();

        public FrmPlay()
        {
            InitializeComponent();
        }

        public void setGame()
        {
            markOfPlayer.Mark = 0;
            markOfComputer.Mark = 0;
            markOfComputer.Borrow = 0;
            markOfPlayer.Borrow = 0;

            lstSquare.Add(flpYou1);
            lstSquare.Add(flpYou2);
            lstSquare.Add(flpYou3);
            lstSquare.Add(flpYou4);
            lstSquare.Add(flpYou5);
            lstSquare.Add(flpMandarin1);
            lstSquare.Add(flpComputer5);
            lstSquare.Add(flpComputer4);
            lstSquare.Add(flpComputer3);
            lstSquare.Add(flpComputer2);
            lstSquare.Add(flpComputer1);
            lstSquare.Add(flpMandarin2);

            for (int i = 0; i < 11; i++)
            {
                if (i != 5)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        addButton(lstSquare[i]);
                    }
                    Application.DoEvents();
                }
            }
            Button mand1 = new Button();
            mand1.Size = new Size(20, 20);
            mand1.BackColor = Color.Black;
            flpMandarin1.Controls.Add(mand1);
            Button mand2 = new Button();
            mand2.Size = new Size(20, 20);
            mand2.BackColor = Color.Black;
            flpMandarin2.Controls.Add(mand2);
            btnEasyMode.Visible = false;
            btnHardMode.Visible = false;
            lblMode.Visible = false;
            for (int i = 0; i < 12; i++)
            {
                if (i == 5 || i == 11)
                {
                    amountEachSquare[i] = 10;
                }
                else
                {
                    amountEachSquare[i] = 5;
                }
            }
        }

        public bool gameRule()
        {
            if (direction == "right")
            {
                nextSquare = (square + 1) % 12;
                laterSquare = (square + 2) % 12;
                if (nextSquare != 5 && nextSquare != 11 && amountEachSquare[nextSquare] != 0)
                {
                    square = nextSquare;
                    lstSquare[nextSquare].Controls.Clear();
                    spreadSquare(nextSquare, direction);
                    return true;
                }
                while (true)
                {
                    if (amountEachSquare[nextSquare] == 0 && amountEachSquare[laterSquare] != 0)
                    {
                        if(laterSquare == 5 && amountEachSquare[laterSquare] < 15 && quan1 == true)
                        {
                            lblNotice.Text = "Quan non, mất lượt";
                            lblNotice.Visible = true;
                            Application.DoEvents();
                            Thread.Sleep(1000);
                            lblNotice.Visible = false;
                            return false;
                        }
                        if (laterSquare == 11 && amountEachSquare[laterSquare] < 15 && quan2 == true)
                        {
                            lblNotice.Text = "Quan non, mất lượt";
                            lblNotice.Visible = true;
                            Application.DoEvents();
                            Thread.Sleep(1000);
                            lblNotice.Visible = false;
                            return false;
                        }
                        if(laterSquare == 5)
                        {
                            quan1 = false;
                        }
                        if(laterSquare == 11)
                        {
                            quan2 = false;
                        }
                        lblTrue.Visible = true;
                        Application.DoEvents();
                        Thread.Sleep(1000);
                        lblTrue.Visible = false;
                        earnSquare(laterSquare);
                        nextSquare = (nextSquare + 2) % 12;
                        laterSquare = (laterSquare + 2) % 12;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                nextSquare = (square + 11) % 12;
                laterSquare = (square + 10) % 12;
                if (amountEachSquare[nextSquare] != 0 && nextSquare != 5 && nextSquare != 11)
                {
                    square = nextSquare;
                    lstSquare[nextSquare].Controls.Clear();
                    spreadSquare(nextSquare, direction);
                    return true;
                }
                while (true)
                {
                    if (amountEachSquare[nextSquare] == 0 && amountEachSquare[laterSquare] != 0)
                    {
                        if (laterSquare == 5 && amountEachSquare[laterSquare] < 15 && quan1 == true)
                        {
                            lblNotice.Text = "Quan non, mất lượt";
                            lblNotice.Visible = true;
                            Application.DoEvents();
                            Thread.Sleep(1000);
                            lblNotice.Visible = false;
                            return false;
                        }
                        if (laterSquare == 11 && amountEachSquare[laterSquare] < 15 && quan2 == true)
                        {
                            lblNotice.Text = "Quan non, mất lượt";
                            lblNotice.Visible = true;
                            Application.DoEvents();
                            Thread.Sleep(1000);
                            lblNotice.Visible = false;
                            return false;
                        }
                        if (laterSquare == 5)
                        {
                            quan1 = false;
                        }
                        if (laterSquare == 11)
                        {
                            quan2 = false;
                        }
                        lblTrue.Visible = true;
                        Application.DoEvents();
                        Thread.Sleep(1000);
                        lblTrue.Visible = false;
                        earnSquare(laterSquare);
                        nextSquare = (nextSquare + 10) % 12;
                        laterSquare = (laterSquare + 10) % 12;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public void spreadSquare(int k, string direction)
        {
            Thread.Sleep(1000);
            int count = amountEachSquare[k];
            amountEachSquare[k] = 0;
            if (direction == "right")
            {
                square = (square + count) % 12;
                for (int i = 1; i <= count; i++)
                {
                    int j = (i + k) % 12;
                    addButton(lstSquare[j]);
                    amountEachSquare[j]++;
                    Application.DoEvents();
                    Thread.Sleep(1000);
                }
            }
            else
            {
                square = (square - count + 36) % 12;
                for (int i = 1; i <= count; i++)
                {
                    int j = (36 + k - i) % 12;
                    addButton(lstSquare[j]);
                    amountEachSquare[j]++;
                    Application.DoEvents();
                    Thread.Sleep(1000);
                }
            }
        }

        public void earnSquare(int k)
        {
            lstSquare[k].Controls.Clear();
            if (turn % 2 != 0)
            {
                markOfPlayer.Mark += amountEachSquare[k];
                lblResultOfYou.Text = markOfPlayer.Mark.ToString();
            }
            else
            {
                markOfComputer.Mark += amountEachSquare[k];
                lblResultOfComputer.Text = markOfComputer.Mark.ToString();
            }
            amountEachSquare[k] = 0;
        }

        public bool endGame()
        {
            Application.DoEvents();
            Thread.Sleep(1000);
            if (amountEachSquare[5] == 0 && amountEachSquare[11] == 0)
            {
                for(int i = 0; i < 5; i++)
                {
                    markOfPlayer.Mark += amountEachSquare[i];
                    markOfComputer.Mark += amountEachSquare[i + 6];
                    lstSquare[i].Controls.Clear();
                    lstSquare[i + 6].Controls.Clear();
                }
                markOfComputer.Mark += markOfComputer.Borrow * 5;
                markOfPlayer.Mark += markOfPlayer.Borrow * 5;
                lblResultOfComputer.Text = markOfComputer.Mark.ToString();
                lblResultOfYou.Text = markOfPlayer.Mark.ToString();
                Application.DoEvents();
                Thread.Sleep(1000);
                notifyResult();
                btnReplay.Visible= true;
                btnExit.Visible = true;
                changeEnabledOfButton(false);
                return true;
            }
            return false;
        }

        public void notifyResult()
        {
            if (markOfPlayer.Mark > markOfComputer.Mark)
            {
                MessageBox.Show($"Điểm của bạn: {markOfPlayer.Mark}\nĐiểm của máy: {markOfComputer.Mark}\nGame kết thúc. Bạn thắng", "Thông báo");
            }
            else if (markOfPlayer.Mark < markOfComputer.Mark)
            {
                MessageBox.Show($"Điểm của bạn: {markOfPlayer.Mark}\nĐiểm của máy: {markOfComputer.Mark}\nGame kết thúc. Máy thắng", "Thông báo");
            }
            else
            {
                MessageBox.Show($"Điểm của bạn: {markOfPlayer.Mark}\nĐiểm của máy: {markOfComputer.Mark}\nGame kết thúc. Hòa nhau", "Thông báo");
            }
        }

        public void borrowOfComputer()
        {
            if (markOfComputer.Mark >= 5)
            {
                markOfComputer.Mark -= 5;
                lblResultOfComputer.Text = markOfComputer.Mark.ToString();
            }
            else
            {
                markOfComputer.Mark -= 5;
                markOfPlayer.Mark += markOfComputer.Mark;
                markOfPlayer.Borrow++;
                lblResultOfComputer.Text = markOfComputer.Mark.ToString();
                lblResultOfYou.Text = markOfPlayer.Mark.ToString();
            }
        }

        public void borrowOfPlayer()
        {
            if (markOfPlayer.Mark >= 5)
            {
                markOfPlayer.Mark -= 5;
                lblResultOfYou.Text = markOfPlayer.Mark.ToString();
            }
            else
            {
                markOfPlayer.Mark -= 5;
                markOfComputer.Mark += markOfPlayer.Mark;
                markOfComputer.Borrow++;
                lblResultOfComputer.Text = markOfComputer.Mark.ToString();
                lblResultOfYou.Text = markOfPlayer.Mark.ToString();
            }
        }

        public int checkSquare(int first, int last)
        {
            int k = 0;
            for (int i = first; i <= last; i++)
            {
                if (amountEachSquare[i] == 0)
                {
                    k++;
                }
            }
            return k;
        }

        public void computerTurn()
        {
            lblNotice.Text = "Đến lượt máy";
            lblNotice.Visible = true;
            Application.DoEvents();
            Thread.Sleep(1000);
            lblNotice.Visible = false;
            turn = 0;
            if (checkSquare(6, 10) == 5)
            {
                borrowOfComputer();
                for(int i = 6; i < 11; i++)
                {
                    addButton(lstSquare[i]);
                    amountEachSquare[i] = 1;
                }
                Application.DoEvents();
                Thread.Sleep(1000);
            }
            int p;
            if (Mode == "Easy")
            {
                Random ran = new Random();
                do
                {
                    p = ran.Next(6, 11);
                } while (amountEachSquare[p] == 0);
                if(ran.Next(0, 10) % 2 == 0)
                {
                    direction = "right";
                }
                else
                {
                    direction = "left";
                }
            }
            else
            {
                BestWay bw = new BestWay();
                (p, direction) = bw.findBestWay(amountEachSquare);
            }
            lstSquare[p].Controls.Clear();
            Application.DoEvents();
            Thread.Sleep(2000);
            int count = amountEachSquare[p];
            amountEachSquare[p] = 0;
            square = p;
            if(direction == "right")
            {
                lblComputerDirection.Text = "<------";
                lblComputerDirection.Visible = true;
                Application.DoEvents();
                Thread.Sleep(1000);
                lblComputerDirection.Visible = false;
                square = (count + square) % 12;
                for (int i = 1; i <= count; i++)
                {
                    int j = (i + p) % 12;
                    addButton(lstSquare[j]);
                    amountEachSquare[j]++;
                    Application.DoEvents();
                    Thread.Sleep(1000);
                }
                while (gameRule())
                {
                    Application.DoEvents();
                    Thread.Sleep(1000);
                }
            }
            else
            {
                lblComputerDirection.Text = "------>";
                lblComputerDirection.Visible = true;
                Application.DoEvents();
                Thread.Sleep(1000);
                lblComputerDirection.Visible = false;
                square = (36 + square - count) % 12;
                for (int i = 1; i <= count; i++)
                {
                    int j = (36 - i + p) % 12;
                    addButton(lstSquare[j]);
                    amountEachSquare[j]++;
                    Application.DoEvents();
                    Thread.Sleep(1000);
                }
                while (gameRule())
                {
                    Application.DoEvents();
                    Thread.Sleep(1000);
                }
            }
            if (endGame())
            {
                return;
            }
            turn = 1;
            lblNotice.Text = "Đến lượt bạn";
            lblNotice.Visible = true;
            Application.DoEvents();
            Thread.Sleep(1000);
            changeEnabledOfButton(true);
            lblNotice.Visible = false;
            if (checkSquare(0, 4) == 5)
            {
                borrowOfPlayer();
                for(int i = 0; i < 5; i++)
                {
                    addButton(lstSquare[i]);
                    amountEachSquare[i] = 1;
                }
                Application.DoEvents();
                Thread.Sleep(1000);
            }
        }
        private void addButton(FlowLayoutPanel button)
        {
            Button btn = new Button();
            btn.Size = new Size(12, 12);
            btn.BackColor = Color.Red;
            button.Controls.Add(btn);
        }

        public void changeEnabledOfButton(bool enabled)
        {
            btnLeft1.Enabled = enabled;
            btnLeft2.Enabled = enabled;
            btnLeft3.Enabled = enabled;
            btnLeft4.Enabled = enabled;
            btnLeft5.Enabled = enabled;
            btnRight1.Enabled = enabled;
            btnRight2.Enabled = enabled;
            btnRight3.Enabled = enabled;
            btnRight4.Enabled = enabled;
            btnRight5.Enabled = enabled;
        }

        private void btnLeft1_Click(object sender, EventArgs e)
        {
            Button btn = (Button) sender;
            int k = 0;
            switch(btn.Name)
            {
                case "btnLeft1":
                    k = 0;
                    break;
                case "btnLeft2":
                    k = 1;
                    break;
                case "btnLeft3":
                    k = 2;
                    break;
                case "btnLeft4":
                    k = 3;
                    break;
                case "btnLeft5":
                    k = 4;
                    break;
            }
            if (amountEachSquare[k] == 0)
            {
                MessageBox.Show("Không thể chọn ô không có dân", "Thông báo");
                return;
            }
            changeEnabledOfButton(false);
            direction = "left";
            lstSquare[k].Controls.Clear();
            Thread.Sleep(1000);
            int count = amountEachSquare[k];
            amountEachSquare[k] = 0;
            square = (36 + k - count) % 12;
            for (int i = 1; i <= count; i++)
            {
                int j = (36 + k - i) % 12;
                addButton(lstSquare[j]);
                amountEachSquare[j]++;
                Application.DoEvents();
                Thread.Sleep(1000);
            }
            while (gameRule())
            {
                Application.DoEvents();
                Thread.Sleep(1000);
            }
            if (endGame())
            {
                return;
            }
            computerTurn();
        }

        private void btnRight1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int k = 0;
            switch (btn.Name)
            {
                case "btnRight1":
                    k = 0;
                    break;
                case "btnRight2":
                    k = 1;
                    break;
                case "btnRight3":
                    k = 2;
                    break;
                case "btnRight4":
                    k = 3;
                    break;
                case "btnRight5":
                    k = 4;
                    break;
            }
            if (amountEachSquare[k] == 0)
            {
                MessageBox.Show("Không thể chọn ô không có dân", "Thông báo");
                return;
            }
            changeEnabledOfButton(false);
            direction = "right";
            lstSquare[k].Controls.Clear();
            Thread.Sleep(1000);
            int count = amountEachSquare[k];
            amountEachSquare[k] = 0;
            square = (count + k) % 12;
            for (int i = 1; i <= count; i++)
            {
                int j = (i + k) % 12;
                addButton(lstSquare[j]);
                amountEachSquare[j]++;
                Application.DoEvents();
                Thread.Sleep(1000);
            }
            while (gameRule())
            {
                Application.DoEvents();
                Thread.Sleep(1000);
            }
            if (endGame())
            {
                return;
            }
            computerTurn();
        }

        private void mnuReplay_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPlay play = new FrmPlay();
            play.ShowDialog();
            this.Close();
        }

        private void mnuGuide_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("guideline.txt");
            string guide = sr.ReadToEnd();
            MessageBox.Show(guide, "Cách chơi");
        }

        private void btnEasyMode_Click(object sender, EventArgs e)
        {
            setGame();
            Mode = "Easy";
            Random rd = new Random();
            turn = rd.Next(0, 10);
            if (turn % 2 == 0)
            {
                computerTurn();
            }
            else
            {
                lblNotice.Visible = true;
                lblNotice.Text = "Đến lượt bạn";
                changeEnabledOfButton(true);
                Application.DoEvents();
                Thread.Sleep(1000);
                lblNotice.Visible = false;
            }
        }

        private void btnHardMode_Click(object sender, EventArgs e)
        {
            setGame();
            Mode = "Hard";
            Random rd = new Random();
            turn = rd.Next(0, 10);
            if (turn % 2 == 0)
            {
                computerTurn();
            }
            else
            {
                lblNotice.Visible = true;
                lblNotice.Text = "Đến lượt bạn";
                changeEnabledOfButton(true);
                Application.DoEvents();
                Thread.Sleep(1000);
                lblNotice.Visible = false;
            }
        }

        private void btnReplay_Click(object sender, EventArgs e)
        {
            mnuReplay_Click(sender, e);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
