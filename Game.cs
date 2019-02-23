using System;
using System.Windows.Forms;

namespace _2048
{


    class Game
    {
        private int[][] iCell;
        private Random random = new Random();
        private Boolean gameOver = false;
        private int skor = 0;
        private int hamle = 0;
        private int[][] temp;

        public int Skor { get => skor; set => skor = value; }
        public int Hamle { get => hamle; set => hamle = value; }

        public Game()
        {
            iCell = new int[4][];
            for (int i = 0; i < 4; i++)
            {
                iCell[i] = new int[4];
            }

        }
        public int[][] Cell()
        {
            return iCell;
        }
        public int[][] StartingDraw()
        {

            iCell[Randomm()[0]][Randomm()[1]] = 2;
            iCell[Randomm()[0]][Randomm()[1]] = 2;
            return iCell;
        }
        private int[] Randomm()
        {
            int[] index = new int[] { random.Next(0, 4), random.Next(0, 4) };
            return index;
        }
        public int[][] SolHareket()
        {
            bool HareketKontrol = false;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = j + 1; k < 4; k++)
                    {
                        if (iCell[i][k] == 0)
                            continue;
                        else if (iCell[i][k] == iCell[i][j])
                        {
                            iCell[i][j] *= 2;
                            iCell[i][k] = 0;
                            HareketKontrol = true;
                            Skor += iCell[i][j];
                            break;
                        }
                        else
                        {
                            if (iCell[i][j] == 0 && iCell[i][k] != 0)
                            {
                                iCell[i][j] = iCell[i][k];
                                iCell[i][k] = 0;
                                j--;
                                HareketKontrol = true;
                                break;
                            }
                            else if (iCell[i][j] != 0)
                            {

                                break;
                            }

                        }
                    }
                }

            }


            if (HareketKontrol)
            {
                SayiUret();
                Hamle++;
            }

            CheckGameOver();
            return iCell;
        }
        public int[][] AltHareket()
        {
            bool HareketKontrol = false;
            for (int j = 0; j < 4; j++)
            {
                for (int i = 3; i >= 0; i--)
                {
                    for (int k = i - 1; k >= 0; k--)
                    {
                        if (iCell[k][j] == 0)
                        {
                            continue;
                        }
                        else if (iCell[k][j] == iCell[i][j])
                        {
                            iCell[i][j] *= 2;

                            iCell[k][j] = 0;
                            HareketKontrol = true;
                            Skor += iCell[i][j];
                            break;
                        }
                        else
                        {
                            if (iCell[i][j] == 0 && iCell[k][j] != 0)
                            {
                                iCell[i][j] = iCell[k][j];
                                iCell[k][j] = 0;
                                i++;
                                HareketKontrol = true;
                                break;
                            }
                            else if (iCell[i][j] != 0)
                            {
                                break;
                            }
                        }
                    }
                }
            }
            if (HareketKontrol)
            {
                SayiUret();
                Hamle++;
            }

            CheckGameOver();
            return iCell;
        }
        public int[][] SagHareket()
        {
            bool HareketKontrol = false;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 3; j >= 0; j--)
                {
                    for (int k = j - 1; k >= 0; k--)
                    {
                        if (iCell[i][k] == 0)
                        {
                            continue;
                        }
                        else if (iCell[i][k] == iCell[i][j])
                        {
                            iCell[i][j] *= 2;
                            iCell[i][k] = 0;
                            HareketKontrol = true;
                            Skor += iCell[i][j];
                            break;
                        }
                        else
                        {
                            if (iCell[i][j] == 0 && iCell[i][k] != 0)
                            {
                                iCell[i][j] = iCell[i][k];
                                iCell[i][k] = 0;
                                j++;
                                HareketKontrol = true;
                                break;
                            }
                            else if (iCell[i][j] != 0)
                            {
                                break;
                            }
                        }
                    }
                }
            }
            if (HareketKontrol)
            {
                SayiUret();
                Hamle++;
            }
            CheckGameOver();
            return iCell;
        }
        public int[][] UstHareket()
        {
            bool HareketKontrol = false;
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int k = i + 1; k < 4; k++)
                    {
                        if (iCell[k][j] == 0)
                        {
                            continue;
                        }
                        //2 kat olma durumu
                        else if (iCell[k][j] == iCell[i][j])
                        {
                            iCell[i][j] *= 2;

                            iCell[k][j] = 0;
                            HareketKontrol = true;
                            Skor += iCell[i][j];
                            break;
                        }
                        else
                        {//
                            if (iCell[i][j] == 0 && iCell[k][j] != 0)
                            {
                                iCell[i][j] = iCell[k][j];
                                iCell[k][j] = 0;
                                i--;
                                HareketKontrol = true;
                                break;
                            }
                            else if (iCell[i][j] != 0)
                            {

                                break;

                            }
                        }
                    }
                }
            }
            if (HareketKontrol)
            {
                SayiUret();
                Hamle++;
            }
            CheckGameOver();
            return iCell;
        }
        private void SayiUret()
        {
            int[] temp = Randomm();
            while (iCell[temp[0]][temp[1]] != 0)
            {
                temp = Randomm();
            }
            iCell[temp[0]][temp[1]] = 2;
        }
        public void CheckGameOver()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i - 1 >= 0)
                    {
                        if (iCell[i - 1][j] == iCell[i][j])
                        {
                            return;
                        }
                    }

                    if (i + 1 < 4)
                    {
                        if (iCell[i + 1][j] == iCell[i][j])
                        {
                            return;
                        }
                    }

                    if (j - 1 >= 0)
                    {
                        if (iCell[i][j - 1] == iCell[i][j])
                        {
                            return;
                        }
                    }

                    if (j + 1 < 4)
                    {
                        if (iCell[i][j + 1] == iCell[i][j])
                        {
                            return;
                        }
                    }

                    if (iCell[i][j] == 0)
                    {
                        return;
                    }
                }
            }

            gameOver = true;
        }
        public int[][] Hareket(int anahtar)
        {
            if (gameOver)
            {
                MessageBox.Show("Bitti");
            }
            else
            {
                switch (anahtar)
                {
                    case 1:
                        UstHareket();
                        break;
                    case 2:
                        AltHareket();
                        break;
                    case 3:
                        SagHareket();
                        break;
                    case 4:
                        SolHareket();
                        break;
                }
            }
            return iCell;
        }
     
        
    }
   

}
