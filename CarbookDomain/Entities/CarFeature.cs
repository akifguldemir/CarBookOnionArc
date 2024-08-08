﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbookDomain.Entities
{
    public class CarFeature
    {
        public int CarFeatureID { get; set; }
        public int CarID { get; set; }
        public Car Car { get; set; }
        public int FeautureID { get; set; }
        public Feature Feature { get; set; }
        public bool Available { get; set; }
    }
}
