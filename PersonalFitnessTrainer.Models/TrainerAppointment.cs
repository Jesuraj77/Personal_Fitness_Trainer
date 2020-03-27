using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalFitnessTrainer.Models
{
  public  class TrainerAppointment
    {
        public int AppointmentNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public long MobileNumber { get; set; }
        public string Address { get; set; }
        public string TraineePreference { get; set; }
    }
}
