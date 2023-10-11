﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Models;

namespace Test.Views
{
    public interface IEmissionView
    {
        public string Source { get; set; }
        public string Unit { get; set; }
        public double Value { get; set; }
        public string Location { get; set; }

        event EventHandler AddButtonClicked;
        event EventHandler DisplayButtonClicked;

        void DisplayData(List<EmissionModel> emissions);

        void ShowMessage(string message);
    }
}