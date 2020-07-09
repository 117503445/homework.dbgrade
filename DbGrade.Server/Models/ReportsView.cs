﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tro.DbGrade.Server.Models.Types;

namespace Tro.DbGrade.Server.Models
{
    public class ReportsView
    {
        public string Sno { get; set; }
        public string SName { get; set; }
        public Sex SSex { get; set; }
        public int SAge { get; set; }
        public double Grade { get; set; }
        public double TotalCredit { get; set; }
        public int Cno { get; set; }
        public int CYear { get; set; }
        public string CName { get; set; }
        public int Pno { get; set; }
        public string PName { get; set; }
        public int Prno { get; set; }
        public string PrName { get; set; }
        public int Cino { get; set; }
        public string CiName { get; set; }
        public int Ono { get; set; }
        public int Cono { get; set; }
        public string CoName { get; set; }
        public double Credit { get; set; }
        public int Period { get; set; }

        public Way Way { get; set; }
        public int Year { get; set; }
        public Term Term { get; set; }
        public string Tno { get; set; }
        public string TName { get; set; }
        public int TAge { get; set; }
        public Sex Tsex { get; set; }
        public Level Level { get; set; }
        public string Phone { get; set; }
    }
}