using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Clinic_Management.Models;

namespace Clinic_Management.Controllers
{
    public class PatientController : Controller
    {
        // GET: Patient/Random
        public ActionResult Random()
        {
            var patient = new Patient() { Name = "Ash"};

            return View(patient);
        }
    }
}