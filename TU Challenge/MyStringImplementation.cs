using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyStringImplementation
    {
        public static string BazardString(string input)
        {
            string result = "";
            string subresult = "";
            for (int i = 0;i < input.Length;i++)
            {
                if (i % 2 != 0){
                    subresult+= input[i];
                }
                else
                {
                    result+= input[i];
                }
            }
            return result + subresult;
        }

        public static bool IsNullEmptyOrWhiteSpace(string input)
        {
            if (input == null || input.Length == 0)
            {
                return true;
            }
            for(int i =0; i <input.Length; i++)
            {
                if (input[i]!= ' ')
                {
                    return false;
                }
            }
            return true;
        }

        public static string MixString(string a, string b)
        {
            if (IsNullEmptyOrWhiteSpace(a)|| IsNullEmptyOrWhiteSpace(b))
            {
                throw new ArgumentException();
            }
            int count = a.Length;
            string result = "";
            if(count<b.Length)
            {
                count = b.Length;
            }
            for(int i=0; i<count; i++)
            {
                if (a.Length > i)
                {
                    result += a[i];
                }
                if (b.Length > i)
                {
                    result += b[i];
                }
            }
            return result;
        }

        public static string Reverse(string a)
        {
            string result = "";
            int longueur = a.Length;
            for(int i=0; i< longueur; i++)
            {
                result += a[longueur-1 - i];
            }
            return result;
        }

        public static string ToCesarCode(string input, int offset)
        {
            string result = "";
            for(int i = 0;i< input.Length;i++)
            {
                if (input[i] == ' ')
                {
                    result += ' ';
                }
                else
                {
                    result += (char)((((int)input[i] % 97) + offset) % 26 + 97);
                }
            }
            return result;
        }

        public static string ToLowerCase(string a)
        {
            string result = "";
            for (int i =0; i<a.Length;i++)
            {
                if (((int)a[i] >= 65 && (int)a[i]<97) || (int)a[i] == 201)
                {
                    result+= (char)((int)a[i] + 32);
                }
                if (((int)a[i] < 65 && (int)a[i] >= 97)|| (int)a[i] ==233)
                {
                    result += (char)((int)a[i] - 32);
                }
                if (!((int)a[i] >= 65 && (int)a[i] < 97) && !((int)a[i] < 65 && (int)a[i] >= 97) && (int)a[i]!=233 && (int)a[i] != 201)
                {
                    result += a[i];
                }
            }
            return result;
        }

        public static string UnBazardString(string input)
        {
            string result = "";
            for (int i = 0; i < input.Length/2; i++)
            {
                    result += input[i];
                    result += input[i + input.Length / 2];

            }
            return result;
        }

        public static string Voyelles(string a)
        {
            string result="";
            List<char> voyelles = new List<char> { 'a', 'e', 'i', 'o', 'u', 'y' };
            for (int i = 0; i<a.Length; i++) {
                string voyelle = ToLowerCase(""+a[i]);
                if (voyelles.Contains(voyelle[0]) && !result.Contains(voyelle[0]))
                {
                    result += voyelle[0];
                }
            }
            return result;
        }
    }
}
