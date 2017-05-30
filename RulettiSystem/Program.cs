using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RulettiSystem
{
    static class Program
    {

        public static int winNumber = 0;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

       public static int getWinningNumber()
        {
            Random random = new Random();

            double encoded = random.NextDouble();
            Console.WriteLine("Encoded: " + encoded);
            double winNumFloat = encoded * 15;
            int winNum = (int)Math.Round(winNumFloat);

            if(winNum >= 15)
            {
                winNum = 14;
            }

            Console.WriteLine("Win Number: " + winNum + " (" + winNumFloat + ")");
            return winNum;
        }

        public static String getWinningColor()
        {
            String r = "Red";
            String b = "Black";
            String g = "Green";

            if (winNumber > 7 && winNumber != 0)
            {
                return b;
            }
            else if (winNumber <= 7 && winNumber != 0)
            {
                return r;
            }
            else if (winNumber == 0)
            {
                return g;
            }

            return "";
        }

    }
}
