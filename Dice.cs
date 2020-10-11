using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceTool
{
    class Dice
    {
        public static int[] Roll(int a, int b)//Roll(骰子数，骰子面数）
        {
            List<int> list = new List<int>();
            Random Rnd = new Random();

            if (a < 1 || b < 1)
            { return null; }//骰子数或面数低于1时抛出null

            else
            {
                for (int i = 1; i <= a; i++)//连续丢出a个骰子
                {
                    int j = Rnd.Next(1, b + 1);//骰子面数为b，丢一次骰子，得数为j
                    list.Add(j);//把骰子得数添加到List集合
                }

                //此处不承担排序功能
                //list.Sort()升序
                //反转为降序：list.Reverse();

                int[] List = new int[list.Count];//定义长度为list长度的int数组List

                for (int i = 0; i < list.Count; i++)
                {
                    List[i] = (int)list[i];
                }
                return List;//返回包括所有骰子结果的int数组
            }
        }

    }




}

