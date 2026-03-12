-- Create Database BankApp;
use bankApp;
Create Table accounts(
	AccountNumber varchar(36) Primary Key,
    Owner varchar(100),
    Balance Decimal(12,2),
    InterestRate Decimal(5,2)
);