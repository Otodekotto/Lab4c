using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageWindowsForm
{
    public class ScoreBoard
    {
        public string Name { get; set; }
        public int PracticedWords { get; set; }
        public int Score { get; set; }

        public ScoreBoard(string name)
        {
            Name = name;
        }
    }
}
