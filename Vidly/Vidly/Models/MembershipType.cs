﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vidly.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
        [Display (Name = "Membership Name")]
        public string MembershipName { get; set; }

        public static readonly byte Unknown = 0;
        public static readonly byte PayAsGo = 1;
    }
}
