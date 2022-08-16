﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.ViewModels.Utilities.Slide
{
    public class SlideVm
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string Image { get; set; }
        public string Url { set; get; }
        public int SortOrder { get; set; }
        public Status Status { set; get; }
    }

    public enum Status
    {
        InActive,
        Active
    }
}
