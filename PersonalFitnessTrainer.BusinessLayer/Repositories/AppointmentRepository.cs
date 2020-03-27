using PersonalFitnessTrainer.Models;
using SpringMvcApp.DataLeyer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFitnessTrainer.BusinessLayer.Repositories
{
   public class AppointmentRepository
    {
        private readonly IDbConnectionFactory _dbConnectionFactory;

        public AppointmentRepository(IDbConnectionFactory dbConnectionFactory)
        {
            _dbConnectionFactory = dbConnectionFactory;

        }

        public async Task<TrainerAppointment> ProcessAppointmentAsync(TrainerAppointment appointment)
        {
            try
            {
                var connection = await _dbConnectionFactory.CreateConnectionAsync();

                await connection.ExecuteAsync("Insert into User (Id, UserName, Password, ConfirmPassword, Email, Photo) VALUES (@id, @userName,@password,@confirmPassword,@email,@photo)", new { id = user.Id, userName = user.UserName, password = user.Password, confirmPassword = user.ConfirmPassword, email = user.Email, photo = user.Photo });
                return user;
            }
            catch (Exception ex)
            {
                throw (ex);
            }



        }
    }
}
