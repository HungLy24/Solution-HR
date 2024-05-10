﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Domain.Common
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatDate { get; set; }
        public string? CreateBy { get; set; }

        public DateTime DateModified {  get; set; }
        public string? ModifiedBy { get; set; } 
    }
}
