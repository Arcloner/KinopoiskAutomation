using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exe7.LitterDeleter
{
    public class Parser
    {
        string sourceString;

        public Parser(string entryString)
        {
            sourceString = entryString;
        }

        public string DeleteLitters(string firstChar, string SecondChar)
        {
            return string.Join(firstChar+SecondChar, sourceString.Split(Convert.ToChar(SecondChar))
                                 .Select(p => p.Split(Convert.ToChar(firstChar))[0].Trim()));
        }
    }
}
