﻿using System.Collections.Generic;

namespace Medex
{
    public class DoctorViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public int WorkYears { get; set; }

        public bool IsAbleToMakePresciptions { get; set; }

        public IEnumerable<PrescriptionViewModel> Prescriptions { get; set; }
    }
}
