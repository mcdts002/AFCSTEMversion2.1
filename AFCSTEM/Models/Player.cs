using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AFCSTEM.Models
{
    public class Player
    {       
        [Key]
        public int ID { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Position { get; set; }
        public int Price { get; set; }
        public int Height { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public double KickAvg { get; set; }
        public int KickTotal { get; set; }
        public double HandballAvg { get; set; }
        public int HandballTotal { get; set; }
        public double DisposalAvg { get; set; }
        public int DisposalTotal { get; set; }
        public double MarksAvg { get; set; }
        public int MarksTotal { get; set; }
        public double HOAvg { get; set; }
        public int HOTotal { get; set; }
        public double ClearanceAvg { get; set; }
        public int ClearanceTotal { get; set; }
        public double CentreClearanceAvg { get; set; }
        public int CentreClearanceTotal { get; set; }
        public double TackleAvg { get; set; }
        public int TackleTotal { get; set; }
        public double GoalsAvg { get; set; }
        public int GoalsTotal { get; set; }
        public double BehindsAvg { get; set; }
        public int BehindsTotal { get; set; }
        public int Matches { get; set; }
    }
}
