using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coolOrange_CandidateChallenge
{
    public class PalindromeChecker
    {
        public static bool IsPalindrome(string s)
        {
            bool result = true;
            for(int i=0; i<s.Length; i++)
            {
                if(s[i]!= s[s.Length-1-i])
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
    }
}
