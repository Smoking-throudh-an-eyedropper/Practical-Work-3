using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Work__3
{
    internal class Questions
    {
        public string question { get; set; }
        public string answer { get; set; }
        public int Point { get; set; }
        public Questions(string questions, string answers, int points)
        {
            question = questions;
            answer = answers;
            Point = points;
        }
    }
}
