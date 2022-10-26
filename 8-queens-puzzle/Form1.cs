using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_queens_puzzle
{
    public partial class Form1 : Form
    {
        //八皇后問題是一個以西洋棋為背景的問題：如何能夠在8×8的西洋棋棋盤上放置八個皇后，使得任何一個皇后都無法直接吃掉其他的皇后
        //為了達到此目的，任兩個皇后都不能處於同一條橫行、縱行或斜線上。八皇后問題可以推廣為更一般的n皇后擺放問題：這時棋盤的大小變為n×n，
        ///而皇后個數也變成n。若且唯若n = 1或n ≥ 4時問題有解。
        int count = 0;
        /// <summary>
        /// Queen數量 queen[n]代表第n+1行 queen[n] value代表第幾列
        /// </summary>
        List<int> queens;
        public Form1()
        {
            InitializeComponent();
        }

        private void PutQueen(int n, List<int> queen, int row)
        {
            for (queen[row] = 1; queen[row] <= n; queen[row]++)//從第一列開始，如果已經超過列數最大值，則回到上一層
            {
                if (CheckQueens(queen, row))
                {
                    row++;
                    if (row < n)//如果列數允許，則繼續往後放並檢查
                    {
                        PutQueen(n, queen, row);//
                    }
                    else
                    {
                        count++;
                        for (int i = 0; i < n; i++)
                        {
                            lst_ans.Items.Add(queen[i].ToString() + " ");
                        }
                    }
                    row--;//如果該行全列皆false，則退回上一行，並且上一行的queen向右位移一列
                }
            }
        }

        /// <summary>
        /// Queen position check
        /// </summary>
        /// <param name="queen"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        private static bool CheckQueens(List<int> queen, int row)
        {
            for (int i = 0; i < row; i++)
            {             
                if (Math.Abs(queen[i] - queen[row]) == Math.Abs(i - row) // 檢查是否在前面queen位置的斜對角或同一列
                    || queen[i] == queen[row])
                {
                    return false;
                }
            }
            return true;
        }

        private void btn_Cal_Click(object sender, EventArgs e)
        {
            lst_ans.Items.Clear();
            int n = Int32.Parse(txt_intput.Text);
            queens = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                queens.Add(0);
            }
            PutQueen(n, queens, 0);
            lst_ans.Items.Add($"{count} results!");
        }
    }
}

