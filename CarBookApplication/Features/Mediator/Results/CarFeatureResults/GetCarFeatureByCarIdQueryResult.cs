﻿using CarbookDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApplication.Features.Mediator.Results.CarFeatureResults
{
    public class GetCarFeatureByCarIdQueryResult
    {
        public int CarFeatureID { get; set; }
        public int CarID { get; set; }
        public string FeatureName { get; set; }
        public int FeatureID { get; set; }
        public bool Available { get; set; }
    }
}
