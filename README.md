# Gym Membership Management System

A desktop application built with **C#** and **Windows Forms (.NET 10)** for managing gym memberships, member registrations, plan renewals, and revenue tracking.

---

## 🚀 Features

- **🔐 Admin Authentication**
  - Secure login interface.
  - Built-in session log out with redirect back to login and clean process termination.

- **📊 Central Dashboard**
  - Live KPI cards: Total Members, Active Members, and Total Monthly Revenue (in ETB).
  - Quick-action shortcuts to register new members or view membership lists.
  - Recent member activity overview.

- **👥 Member Management**
  - Real-time search by full name or phone number.
  - Quick filters by status (*All*, *Active*, *Expired*) and category (*Aerobics*, *Machine*, *Dumbbell*).
  - One-click **Renew Plan** (+1 month extension) with automatic status update.
  - Member deletion with confirmation dialog.

- **📝 Member Registration**
  - Input validation for name and phone number.
  - Category selection with automatic monthly fee calculation:
    - **Aerobics:** 500 ETB / month
    - **Machine:** 500 ETB / month
    - **Dumbbell:** 400 ETB / month
  - Instant synchronization with the central member store.

- **👤 Admin Profile**
  - Account profile view and password update interface.

- **💾 Central Mockup Data Store**
  - Self-contained in-memory repository (`DataStore`) pre-seeded with Ethiopian demo records.
  - Zero external database setup or configuration required for immediate testing and demonstration.

---

## 🔑 Default Login Credentials

| Role | Username | Password |
|---|---|---|
| **Administrator** | `admin` | `admin123` |

---

## 🛠️ Tech Stack & Requirements

- **Language:** C#
- **Framework:** .NET 10.0 (`net10.0-windows`)
- **UI Platform:** Windows Forms (WinForms)
- **OS Requirement:** Windows 10 / 11

---

## 🏁 Getting Started

### 1. Prerequisites
Ensure you have the [.NET 10.0 SDK](https://dotnet.microsoft.com/download) installed on your machine.

### 2. Clone or Open the Repository
Open the solution file (`GymMembership.slnx`) in **Visual Studio 2022 / 2026** or your preferred editor.

### 3. Run via CLI
Alternatively, run the project directly from PowerShell or Command Prompt:

```bash
# Navigate to the project directory
cd GymMembership

# Build the project
dotnet build

# Run the application
dotnet run
```

---

## 📁 Project Structure

```text
GymMembership/
├── Data/
│   ├── Member.cs          # Member data model & active/expired calculations
│   └── DataStore.cs       # Central in-memory repository & seed records
├── Forms/
│   ├── LoginForm.cs       # Authentication & login screen
│   ├── MainForm.cs        # Primary dashboard shell & sidebar navigation
│   ├── DashboardForm.cs   # KPI statistics & summary widgets
│   ├── MembershipForm.cs  # Member directory, search, filters & renewals
│   ├── RegisterForm.cs    # New member registration form
│   └── ProfileForm.cs     # Admin profile management
└── Program.cs             # Application entry point
```

