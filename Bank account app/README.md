# Bank Account WinForms Application

A simple desktop banking application built with **C# WinForms** and **MySQL**.  
The project demonstrates object-oriented programming concepts and basic database integration.

## Features

- Create a new bank account
- Automatically generate a unique **GUID Account Number**
- Deposit money
- Withdraw money
- Create **Savings Accounts with Interest Rate**
- Persist account data using **MySQL**
- Load saved accounts when the application starts
- Display accounts in a **DataGridView**

## Technologies Used

- **C#**
- **.NET WinForms**
- **MySQL**
- **MySQL Workbench**
- **ADO.NET (MySql.Data)**

## Project Structure

Bank_account_app
│
├── Models
│   ├── BankAccount.cs
│   └── SavingsAccount.cs
│
├── Data
│   └── Database.cs
│
├── Forms
│   ├── Form1.cs
│   ├── Form1.Designer.cs
│   └── Form1.resx
│
├── Program.cs
└── Bank_account_app.csproj

### Folder Description

- **Models** → Contains the core banking classes (`BankAccount`, `SavingsAccount`)
- **Data** → Handles database connection logic
- **Forms** → Contains the WinForms UI

## Database Setup

The database script is included in this repository (`database files.sql`).  
Run it in MySQL Workbench to create the `bankapp` database and the `accounts` table.

## Configure Database Connection

Edit `Database.cs` and update the connection string:

```csharp
server=localhost;user=root;password=YOURPASSWORD;database=bankapp;

How to Run
	1.	Clone the repository
	2.	Open the solution in Visual Studio
	3.	Install the NuGet package: MySql.Data
  	4.Ensure MySQL server is running
	5.	Run the application
