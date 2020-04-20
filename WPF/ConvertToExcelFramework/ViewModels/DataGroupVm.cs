﻿using System.ComponentModel;

namespace ConvertToExcelFramework.ViewModels
{
    public class DataGroupVm
    {
        [Description("Parent Row")]
        public int ParentRow { get; set; }

        [Description("Child Row")]
        public int ChildRow { get; set; }

        public bool Orphen { get; set; }
    }
}