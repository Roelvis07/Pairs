using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Pairs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //int k = 1;
            //List<int> arr = new List<int> { 1, 2, 4, 3 }; //3

            //int k = 1;
            //List<int> arr = new List<int> { 363374326, 364147530, 61825163, 1073065718, 1281246024, 1399469912, 428047635, 491595254, 879792181, 1069262793 }; //0

            //int k = 2;
            //List<int> arr = new List<int> { 1, 5, 3, 4, 2 }; //3

            int k = 2;
            List<int> arr = new List<int> { 1, 3, 5, 8, 6, 4, 2 }; //5

            Console.WriteLine(Pairs(k, arr));

            Stopwatch timeMeasure = new Stopwatch();
            timeMeasure.Start();
            int operacion = 10 / 4;
            timeMeasure.Stop();
            Console.WriteLine($"Tiempo: {timeMeasure.Elapsed.TotalMilliseconds} ms");
        }
        //this solution it's work, but is more slow
        public static int Pairs(int k, List<int> arr)
        {
            arr.Sort();
            var result = 0;

            for (int i = 0; i < arr.Count - 1; i++)
            {
                for (int j = arr.Count - 1; j > i; j--)
                {
                    if (arr[j] - arr[i] == k)
                    {
                        result++;
                        break;
                    }                        
                }
            }

            return result;
        }
        //this solution it is more confortable
        public static int Pairs1(int k, List<int> arr)
        {
            arr.Sort();
            var result = 0;

            for (int i = 0; i < arr.Count - 1; i++)
            {
                for (int j = i + 1; j < arr.Count; j++)
                {
                    if (arr[j] - arr[i] == k)
                        result++;
                    if (arr[j] - arr[i] > k)
                        break;
                }

            }

            return result;
        }
    }
}