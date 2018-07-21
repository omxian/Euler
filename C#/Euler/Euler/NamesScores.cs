using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Euler
{
    public class NamesScores
    {
        private string[] sortedNames;
        public long GetTotalScores()
        {
            ReadFile();
            return CountNames();
        }

        private void ReadFile()
        {
            sortedNames = File.ReadAllText("../../../File/p022_names.txt").Split(',');
            Array.Sort(sortedNames);
        }

        private long CountNames()
        {
            long sum = 0;
            for (int i = 0; i < sortedNames.Length; i++)
            {
                string name = sortedNames[i];
                sum += CountWord(name) * (Array.IndexOf(sortedNames, name) + 1);
            }
            return sum;
        }

        public int CountWord(string word)
        {
            int sum = 0;
            for (int i = 0; i < word.Length; i++)
            {
                //忽略多余的"
                if (word[i] == '\"') 
                {
                    continue;
                }

                sum += word[i] - 64;
            }
            return sum;
        } 
    }
}
