using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AFCSTEM.Models
{
    public class Team
    {
        [Key]
        public string StudentId { get; set; }
        public int DEF1 { get; set; }
        public int DEF2 { get; set; }
        public int DEF3 { get; set; }
        public int DEF4 { get; set; }
        public int DEF5 { get; set; }
        public int DEF6 { get; set; }
        public int FWD1 { get; set; }
        public int FWD2 { get; set; }
        public int FWD3 { get; set; }
        public int FWD4 { get; set; }
        public int FWD5 { get; set; }
        public int FWD6 { get; set; }
        public int RUCK1 { get; set; }
        public int RUCK2 { get; set; }
        public int MID1 { get; set; }
        public int MID2 { get; set; }
        public int MID3 { get; set; }
        public int MID4 { get; set; }

    }
}
