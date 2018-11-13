using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyGuide.Models
{
    public class Question
    {
        public int qaID { get; set; }
        public string question { get; set; }
        public string answer { get; set; }
        public int catID { get; set; }
        public int subID { get; set; }
    }
}
