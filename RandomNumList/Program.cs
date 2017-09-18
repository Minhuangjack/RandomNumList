using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumList
{
    class Program
    {
        static void Main(string[] args)
        {
            //給一數列 隨機排序
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Randomnum(num);
        }

        public static void Randomnum(int[] num)
        {
            int[] num2 = num;
            int temp;
            for (int i = 0; i < num2.Length; i++)
            {
                for (int j = 0; j < num2.Length; j++)
                {
                    Random ran = new Random(Guid.NewGuid().GetHashCode());
                    int reannum = ran.Next(0, num2.Length);
                    if (num2[j] == num2[reannum])
                    {
                        temp = num2[j];
                        if (j + 1 < num2.Length)
                        {
                            num2[j] = num2[j + 1];
                            num2[j + 1] = temp;
                        }
                        else
                        {
                            num2[j] = num2[j - 1];
                            num2[j - 1] = temp;
                        }


                    }
                }
            }
        }
}
