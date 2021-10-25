using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilManager
{
    class RandomDataGenerator
    {
        public static string PasswordGenerator(long letters)
        {
            string NewPassword = "";
            Random random = new Random(System.DateTime.Now.Millisecond);
            for (long i = 0; i < letters; i++)
            {
                NewPassword += (char)random.Next(48, 122);
            }
            return NewPassword;
        }

        public static string AutoPasswordGenerator()
        {
            return PasswordGenerator(NumberGenerator(10, 20));
        }

        public static long NumberGenerator(int min, int max)
        {
            Random random = new Random(System.DateTime.Now.Millisecond);
            return random.Next(min, max);
        }
    }
}
