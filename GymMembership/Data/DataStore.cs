using System;
using System.Collections.Generic;
using System.Linq;

namespace GymMembership.Data
{
    /// <summary>
    /// Central in-memory data store for gym members, statistics, and renewal operations.
    /// </summary>
    public static class DataStore
    {
        private static readonly List<Member> _members = new();
        private static int _nextIdCounter = 107;

        static DataStore()
        {
            SeedDemoData();
        }

        /// <summary>
        /// Seeds initial realistic Ethiopian gym demo records.
        /// </summary>
        private static void SeedDemoData()
        {
            _members.Clear();

            _members.Add(new Member
            {
                Id = "MEM-101",
                FullName = "Abebe Bikila",
                Phone = "0911 234 567",
                Category = "Aerobics",
                MonthlyFee = 500m,
                Gender = "Male",
                RegistrationDate = DateTime.Today.AddDays(-10),
                ExpirationDate = DateTime.Today.AddDays(20) // Active
            });

            _members.Add(new Member
            {
                Id = "MEM-102",
                FullName = "Sara Tesfaye",
                Phone = "0922 345 678",
                Category = "Machine",
                MonthlyFee = 500m,
                Gender = "Female",
                RegistrationDate = DateTime.Today.AddDays(-5),
                ExpirationDate = DateTime.Today.AddDays(25) // Active
            });

            _members.Add(new Member
            {
                Id = "MEM-103",
                FullName = "Dawit Getachew",
                Phone = "0933 456 789",
                Category = "Dumbbell",
                MonthlyFee = 400m,
                Gender = "Male",
                RegistrationDate = DateTime.Today.AddDays(-40),
                ExpirationDate = DateTime.Today.AddDays(-10) // Expired
            });

            _members.Add(new Member
            {
                Id = "MEM-104",
                FullName = "Tigist Alemu",
                Phone = "0944 567 890",
                Category = "Aerobics",
                MonthlyFee = 500m,
                Gender = "Female",
                RegistrationDate = DateTime.Today.AddDays(-45),
                ExpirationDate = DateTime.Today.AddDays(-15) // Expired
            });

            _members.Add(new Member
            {
                Id = "MEM-105",
                FullName = "Yonas Tadesse",
                Phone = "0955 678 901",
                Category = "Machine",
                MonthlyFee = 500m,
                Gender = "Male",
                RegistrationDate = DateTime.Today.AddDays(-15),
                ExpirationDate = DateTime.Today.AddDays(15) // Active
            });

            _members.Add(new Member
            {
                Id = "MEM-106",
                FullName = "Hanna Bekele",
                Phone = "0966 789 012",
                Category = "Dumbbell",
                MonthlyFee = 400m,
                Gender = "Female",
                RegistrationDate = DateTime.Today.AddDays(-2),
                ExpirationDate = DateTime.Today.AddDays(28) // Active
            });
        }

        /// <summary>
        /// Returns all members (newest first).
        /// </summary>
        public static List<Member> GetAll()
        {
            return _members.OrderByDescending(m => m.RegistrationDate).ToList();
        }

        /// <summary>
        /// Finds a member by their ID.
        /// </summary>
        public static Member? FindById(string id)
        {
            return _members.FirstOrDefault(m => string.Equals(m.Id, id, StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// Returns the standard monthly price in ETB for a given category.
        /// </summary>
        public static decimal GetFeeByCategory(string category)
        {
            if (string.IsNullOrWhiteSpace(category)) return 500m;

            if (category.Contains("Dumbbell", StringComparison.OrdinalIgnoreCase))
                return 400m;

            // Aerobics & Machine are both 500 ETB
            return 500m;
        }

        /// <summary>
        /// Adds a new member to the central store. Auto-assigns ID and Fee if missing.
        /// </summary>
        public static Member AddMember(Member member)
        {
            if (string.IsNullOrWhiteSpace(member.Id))
            {
                member.Id = $"MEM-{_nextIdCounter++}";
            }

            if (member.MonthlyFee <= 0)
            {
                member.MonthlyFee = GetFeeByCategory(member.Category);
            }

            if (member.ExpirationDate <= member.RegistrationDate)
            {
                member.ExpirationDate = member.RegistrationDate.AddMonths(1);
            }

            _members.Add(member);
            return member;
        }

        /// <summary>
        /// Renews a member's subscription. Extends expiration date by the specified months from today or current expiry.
        /// </summary>
        public static bool RenewMember(string id, int months = 1)
        {
            var member = FindById(id);
            if (member == null) return false;

            // If already expired, renew starting from today; if still active, extend current expiry date
            DateTime baseDate = member.ExpirationDate > DateTime.Today ? member.ExpirationDate : DateTime.Today;
            member.RegistrationDate = DateTime.Today;
            member.ExpirationDate = baseDate.AddMonths(months);

            return true;
        }

        /// <summary>
        /// Deletes a member from the store.
        /// </summary>
        public static bool DeleteMember(string id)
        {
            var member = FindById(id);
            if (member == null) return false;

            return _members.Remove(member);
        }

        // --- KPI & Statistics Helpers ---

        public static int TotalMembersCount => _members.Count;

        public static int ActiveMembersCount => _members.Count(m => m.IsActive);

        public static int ExpiredMembersCount => _members.Count(m => !m.IsActive);

        public static decimal TotalMonthlyRevenue => _members.Where(m => m.IsActive).Sum(m => m.MonthlyFee);
    }
}

