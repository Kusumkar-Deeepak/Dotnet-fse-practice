# Entity Framework Core 8.0 Labs

This folder contains the Entity Framework Core practice work for the Retail Inventory System.

The main project is in [Lab_1_Retail_Inventory_System](Lab_1_Retail_Inventory_System). It uses a SQL Server database and a simple console app to show how Entity Framework Core works.

## Simple Overview

Entity Framework Core helps C# code talk to a database without writing too much SQL by hand.

In this practice set, we learn how to:

- create models
- connect to SQL Server
- create a DbContext
- add data
- read data
- update data
- delete data
- use LINQ queries

## Labs Summary

### Lab 1: ORM Basics

Learn what ORM means and how C# classes connect to database tables.

### Lab 2: DbContext Setup

Create the DbContext and connect the app to SQL Server.

### Lab 3: Migrations

Create tables in the database by using EF Core migrations.

### Lab 4: Add Initial Data

Insert sample category and product records into the database.

### Lab 5: Read Data

Get product data from the database by using EF Core methods.

### Lab 6: Update and Delete Data

Change a product value and remove a product from the database.

## Project Files

Inside [Lab_1_Retail_Inventory_System/RetailInventory](Lab_1_Retail_Inventory_System/RetailInventory) you will find:

- [Program.cs](Lab_1_Retail_Inventory_System/RetailInventory/Program.cs)
- [Data/AppDbContext.cs](Lab_1_Retail_Inventory_System/RetailInventory/Data/AppDbContext.cs)
- [Models/Category.cs](Lab_1_Retail_Inventory_System/RetailInventory/Models/Category.cs)
- [Models/Product.cs](Lab_1_Retail_Inventory_System/RetailInventory/Models/Product.cs)
- [Migrations](Lab_1_Retail_Inventory_System/RetailInventory/Migrations)
- [RetailInventory.csproj](Lab_1_Retail_Inventory_System/RetailInventory/RetailInventory.csproj)

## Main Model Details

### Category

Stores category data.

- Id
- Name
- Products

### Product

Stores product data.

- Id
- Name
- Price
- StockQuantity
- CategoryId
- Category

## Database Setup

The app uses SQL Server in `AppDbContext`.

Database name:

- `RetailInventoryDB`

## Current Code Result

The current `Program.cs` file shows Lab 6 work.

It does these actions:

- finds the `Laptop` product and updates the price
- finds the `Rice Bag` product and deletes it
- prints the remaining products

## Technologies Used

- C#
- .NET Console Application
- Entity Framework Core
- SQL Server
- LINQ

## Notes

- The folder name says EF Core 8.0, but the current project files use .NET 10 and EF Core 10 package versions.
- There is also a file named [Retail_Inventory_System_Output.docx](Lab_1_Retail_Inventory_System/Retail_Inventory_System_Output.docx) in the lab folder.
