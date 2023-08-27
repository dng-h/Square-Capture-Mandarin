using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OAnQuan
{
    internal class BestWay
    {
        public int[] numberOfSquare;
        public int bwNextSquare, bwLaterSquare, bwSquare, bwMark;
        public string bwDirection = "";
        bool bwQuan1 = true, bwQuan2 = true;
        public List<int> lstMark;
        public void getSquare(int[] number)
        {
            numberOfSquare = new int[number.Length];
            for (int i = 0; i < number.Length; i++)
            {
                numberOfSquare[i] = number[i];
            }
        }
        public (int, string) findBestWay(int[] number)
        {
            int num = -1;
            lstMark = new List<int>();
            for (int i = 6; i < 11; i++)
            {
                getSquare(number);
                if (numberOfSquare[i] != 0)
                {
                    int count = numberOfSquare[i];
                    bwDirection = "right";
                    bwSquare = i;
                    bwSquare = (count + bwSquare) % 12;
                    for (int j = 1; j <= count; j++)
                    {
                        int k = (j + i) % 12;
                        numberOfSquare[k]++;
                    }
                    bwMark = 0;
                    while (gameRule())
                    {
                    }
                    lstMark.Add(bwMark);
                    getSquare(number);
                    count = numberOfSquare[i];
                    bwDirection = "left";
                    bwSquare = i;
                    bwSquare = (36 + bwSquare - count) % 12;
                    for (int j = 1; j <= count; j++)
                    {
                        int k = (36 - j + i) % 12;
                        numberOfSquare[k]++;
                    }
                    bwMark = 0;
                    while (gameRule())
                    {
                    }
                    lstMark.Add(bwMark);
                }
                else
                {
                    lstMark.Add(0);
                    lstMark.Add(0);
                }
            }
            int max = 0;
            int index = 0;
            for(int i = 0; i < lstMark.Count; i++)
            {
                if (lstMark[i] > max)
                {
                    index = i;
                    max = lstMark[i];
                }
            }
            if(max == 0)
            {
                for(int i = 6; i < 11; i++)
                {
                    if (number[i] != 0)
                    {
                        Random rd = new Random();
                        if(rd.Next(0,10)%2 == 0)
                        {
                            return (i, "right");
                        }
                        else
                        {
                            return (i, "left");
                        }
                    }
                }
            }
            else
            {
                List<int> lstIndex = new List<int>();
                for (int i = 0; i < lstMark.Count; i++)
                {
                    if (lstMark[i] == max)
                    {
                        lstIndex.Add(i);
                    }
                }
                Random rd = new Random();
                index = lstIndex[rd.Next(0, lstIndex.Count)];
            }
            switch(index)
            {
                case 0:
                    num = 6;
                    bwDirection = "right";
                    break;
                case 1:
                    num = 6;
                    bwDirection = "left";
                    break;
                case 2:
                    num = 7;
                    bwDirection = "right";
                    break;
                case 3:
                    num = 7;
                    bwDirection = "left";
                    break;
                case 4:
                    num = 8;
                    bwDirection = "right";
                    break;
                case 5:
                    num = 8;
                    bwDirection = "left";
                    break;
                case 6:
                    num = 9;
                    bwDirection = "right";
                    break;
                case 7:
                    num = 9;
                    bwDirection = "left";
                    break;
                case 8:
                    num = 10;
                    bwDirection = "right";
                    break;
                case 9:
                    num = 10;
                    bwDirection = "left";
                    break;
            }
            return (num, bwDirection);
        }

        public bool gameRule()
        {
            if (bwDirection == "right")
            {
                bwNextSquare = (bwSquare + 1) % 12;
                bwLaterSquare = (bwSquare + 2) % 12;
                if (bwNextSquare != 5 && bwNextSquare != 11 && numberOfSquare[bwNextSquare] != 0)
                {
                    bwSquare = bwNextSquare;
                    spreadSquare(bwNextSquare, bwDirection);
                    return true;
                }
                while (true)
                {
                    if (numberOfSquare[bwNextSquare] == 0 && numberOfSquare[bwLaterSquare] != 0)
                    {
                        if (bwLaterSquare == 5 && numberOfSquare[bwLaterSquare] < 15 && bwQuan1 == true)
                        {
                            return false;
                        }
                        if (bwLaterSquare == 11 && numberOfSquare[bwLaterSquare] < 15 && bwQuan2 == true)
                        {
                            return false;
                        }
                        bwMark += numberOfSquare[bwLaterSquare];
                        bwNextSquare = (bwNextSquare + 2) % 12;
                        bwLaterSquare = (bwLaterSquare + 2) % 12;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                bwNextSquare = (bwSquare + 11) % 12;
                bwLaterSquare = (bwSquare + 10) % 12;
                if (numberOfSquare[bwNextSquare] != 0 && bwNextSquare != 5 && bwNextSquare != 11)
                {
                    bwSquare = bwNextSquare;
                    spreadSquare(bwNextSquare, bwDirection);
                    return true;
                }
                while (true)
                {
                    if (numberOfSquare[bwNextSquare] == 0 && numberOfSquare[bwLaterSquare] != 0)
                    {
                        if (bwLaterSquare == 5 && numberOfSquare[bwLaterSquare] < 15 && bwQuan1 == true)
                        {
                            return false;
                        }
                        if (bwLaterSquare == 11 && numberOfSquare[bwLaterSquare] < 15 && bwQuan2 == true)
                        {
                            return false;
                        }
                        bwMark += numberOfSquare[bwLaterSquare];
                        bwNextSquare = (bwNextSquare + 10) % 12;
                        bwLaterSquare = (bwLaterSquare + 10) % 12;
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
            int count = numberOfSquare[k];
            numberOfSquare[k] = 0;
            if (direction == "right")
            {
                bwSquare = (bwSquare + count) % 12;
                for (int i = 1; i <= count; i++)
                {
                    int j = (i + k) % 12;
                    numberOfSquare[j]++;
                }
            }
            else
            {
                bwSquare = (bwSquare - count + 36) % 12;
                for (int i = 1; i <= count; i++)
                {
                    int j = (36 + k - i) % 12;
                    numberOfSquare[j]++;
                }
            }
        }
    }
}
