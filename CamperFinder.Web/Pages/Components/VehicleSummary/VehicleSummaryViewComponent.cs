﻿using CamperFinder.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CamperFinder.Web.Pages.Components.VehicleSummary
{
    [ViewComponent]
    public class VehicleSummaryViewComponent : ViewComponent
    {
        public VehicleSummaryViewComponent() { }

        public IViewComponentResult Invoke(Vehicle vehicle)
        {
            return View("VehicleSummary", vehicle);
        }
    }
}
