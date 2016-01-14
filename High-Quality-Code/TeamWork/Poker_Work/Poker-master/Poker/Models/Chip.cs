﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Models
{
    public class Chip
    {
        private const int defaultChipAmount = 10000;
        private int amount;

        public Chip(int amount)
        {
            this.amount = amount;
        }

        public Chip()
            : this(defaultChipAmount)
        {
        }


        public int Amount
        {
            get { return this.amount; }
            set
            {
                this.amount = value < 0 ? 0 : value;
            }
        }

        public override string ToString()
        {
            return string.Format("Chips : {0}", Amount);
        }
    }
}
