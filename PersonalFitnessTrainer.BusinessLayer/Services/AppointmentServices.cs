using PersonalFitnessTrainer.BusinessLayer.Repositories;
using PersonalFitnessTrainer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFitnessTrainer.BusinessLayer.Services
{
   public class AppointmentServices
    {
        private readonly IAppointmentRepository _appointmentRepository;

        public AppointmentServices(IAppointmentRepository repository)
        {
            _appointmentRepository = repository;
        }
    public  Task<TrainerAppointment>  ProcessAppointment(TrainerAppointment appointment)
        {
            _appointment = _appointmentRepository.ProcessAppointment(appointment);
            return _appointment;
        }
    }
}
