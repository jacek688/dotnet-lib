﻿using System.Collections.Generic;

namespace ConvertToExcelFramework.Models
{
    public class Summary
    {
        public Summary()
        {
            Studies = new List<Study>();
        }

        public string Date { get; set; }

        public string Description { get; set; }

        public List<Study> Studies { get; set; }
    }
}