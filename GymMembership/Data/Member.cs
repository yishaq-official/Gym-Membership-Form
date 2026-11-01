using System;

namespace GymMembership.Data
{
    public class Member
    {
        public string Id { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Category { get; set; } = "Aerobics"; // Aerobics (500 ETB), Machine (500 ETB), Dumbbell (400 ETB)
        public decimal MonthlyFee { get; set; } = 500m;
        public string Gender { get; set; } = "Male";
        public string Address { get; set; } = string.Empty;
        public DateTime RegistrationDate { get; set; } = DateTime.Today;
        public DateTime ExpirationDate { get; set; } = DateTime.Today.AddMonths(1);

        /// <summary>
        /// Member is active if expiration date is today or in the future.
        /// </summary>
        public bool IsActive => ExpirationDate.Date >= DateTime.Today;

        /// <summary>
        /// Display status string ("Active" or "Expired").
        /// </summary>
        public string Status => IsActive ? "Active" : "Expired";
    }
}

