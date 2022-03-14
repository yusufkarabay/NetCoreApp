﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }= new Guid();
        public DateTime CreatedDate { get; set; }=DateTime.Now;
        public DateTime UpdatedDate { get; set; } = DateTime.Now;

    }
}
