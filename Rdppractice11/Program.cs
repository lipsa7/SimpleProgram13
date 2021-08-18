using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rdppractice11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = UserProgramCode.checkcharacters("the picture was great");
            Console.WriteLine(n);

            Console.ReadKey();
        }
    }

    class UserProgramCode
    {
        public static int checkcharacters(string str)
        {
            int len = str.Length;
            string str1 = str.Substring(0, 1);
            string str2 = str.Substring(len - 1);
            if (str1.Equals(str2))
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
            }
