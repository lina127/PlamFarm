﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace PlamFarm.Models
{
    public partial class Sold
    {
        public int Id { get; set; }
        public int CowId { get; set; }
        public string Grade { get; set; }
        public int? Price { get; set; }
        public string Comment { get; set; }

        public virtual Cow Cow { get; set; }
    }
}