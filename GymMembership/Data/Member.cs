using System;

namespace GymMembership.Data
{
    public class Member
    {

        //MAIN DATA STURE CLASS FOR A MEMEBERS/BLUE PRINT
        public string Id { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Category { get; set; } = "Aerobics"; // Aerobics, Machine , Dumbbell 
        public decimal MonthlyFee { get; set; } = 500m;
        public string Gender { get; set; } = "Male";
        public string Address { get; set; } = string.Empty;
        public DateTime RegistrationDate { get; set; } = DateTime.Today;
        public DateTime ExpirationDate { get; set; } = DateTime.Today.AddMonths(1);


        /// Member is active if expiration date is today or in the future.

        public bool IsActive => ExpirationDate.Date >= DateTime.Today;


        /// Display status string ("Active" or "Expired").

        public string Status => IsActive ? "Active" : "Expired";
    }
}

