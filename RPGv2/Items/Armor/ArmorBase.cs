﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGv2.Items.Armor
{
    public abstract class ArmorBase : itemBase
    {
        public abstract int ArmorPoints { get; }
}