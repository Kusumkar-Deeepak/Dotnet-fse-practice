# DotNet FSE Practice

This workspace contains SQL Server exercises and C# engineering concept projects completed as part of the DotNet FSE Deep Skilling Program.

## SQL Server Exercises

All SQL scripts were written and tested in SQL Server Management Studio (SSMS).

### Exercise 01 - Ranking and Window Functions

This exercise covers `ROW_NUMBER()`, `RANK()`, `DENSE_RANK()`, `OVER()`, and `PARTITION BY`.

What I practiced:

- Assigning row numbers to records.
- Comparing ranking results for tied values.
- Finding top products per category with window functions.

### Exercise 02 - Indexes

This exercise covers non-clustered, clustered, and composite indexes.

What I practiced:

- Improving search performance with indexes.
- Verifying the clustered index created by the primary key.
- Creating a composite index for filtering by more than one column.

### Exercise 04 - Stored Procedures

This exercise covers procedure creation, input parameters, and returning data.

What I practiced:

- Creating reusable stored procedures.
- Passing values through parameters.
- Returning employee details and counts from procedures.

### Exercise 05 - Functions

This exercise covers scalar functions and nested function usage.

What I practiced:

- Creating a reusable scalar function.
- Calculating annual salary values.
- Querying a specific employee salary using a function.

## Engineering Concepts

### 02 - E-commerce Platform Search Function

Location: [deepskilling/Engineering_Concepts/Data_Structure_And_Algorithms/02_E-commerce Platform Search Function/EcommerceSearchSystem](deepskilling/Engineering_Concepts/Data_Structure_And_Algorithms/02_E-commerce%20Platform%20Search%20Function/EcommerceSearchSystem)

This project compares linear search and binary search on a product list.

What I practiced:

- Searching for a product by ID.
- Comparing a simple search with a faster search on sorted data.
- Printing the product details when a match is found.

### 07 - Financial Forecasting

Location: [deepskilling/Engineering_Concepts/Data_Structure_And_Algorithms/07_Financial Forecasting/FinancialForecasting](deepskilling/Engineering_Concepts/Data_Structure_And_Algorithms/07_Financial%20Forecasting/FinancialForecasting)

This project uses recursion to predict the future value of an investment or amount based on a growth rate.

What I practiced:

- Using recursion in C#.
- Accepting current value, growth rate, and years from the user.
- Calculating the future value step by step.

## Current Folder Structure

```text
Dotnet-fse-practice/
├── README.md
└── deepskilling/
	├── advanced_sql_server/
	│   ├── Exercise_01_Advanced_concepts/
	│   ├── Exercise_02_Indexes/
	│   ├── Exercise_04_Stored_Procedures/
	│   └── Exercise_05_Functions/
	└── Engineering_Concepts/
		└── Data_Structure_And_Algorithms/
			├── 02_E-commerce Platform Search Function/
			└── 07_Financial Forecasting/
```

## Tools Used

- Microsoft SQL Server
- SQL Server Management Studio (SSMS)
- C#
- .NET
- Git
- GitHub
- Visual Studio Code

## Summary

This workspace shows practical work in both SQL Server and C#. The SQL exercises focused on writing better queries and building reusable database logic, while the engineering projects focused on search algorithms and recursion in a simple, real-world way.
