# Exercise 08 - Exception Handling

## Objective

To understand error handling mechanisms available in SQL Server.

---

## Concepts Covered

1. TRY...CATCH
2. Error Logging
3. THROW
4. RAISERROR
5. Nested TRY...CATCH
6. Transactions with Error Handling

---

## Files

### setup.sql
Creates AuditLog table and prepares the environment.

### 01_basic_try_catch.sql
Implements basic TRY...CATCH error handling.

### 02_throw_error.sql
Logs errors and re-throws them using THROW.

### 03_custom_raiserror.sql
Implements business rule validation using RAISERROR.

### 04_nested_try_catch.sql
Demonstrates nested exception handling.

### 05_transaction_error_handling.sql
Uses transactions with rollback on failure.

### 06_dynamic_raiserror.sql
Raises different errors based on severity levels.

---

## Learning Outcomes

- Understand SQL Server exception handling.
- Learn error logging.
- Learn custom error generation.
- Understand transaction rollback.
- Learn nested error handling.

---

## SQL Concepts Used

- TRY
- CATCH
- THROW
- RAISERROR
- TRANSACTION
- COMMIT
- ROLLBACK

---

## Stored Procedures Created

### AddEmployee
Handles employee insertion with exception handling.

### TransferEmployee
Transfers employees between departments safely.

### BatchInsertEmployees
Performs transactional inserts.

### CheckSalary
Validates salary values using custom errors.

---

## Result

Successfully implemented and tested SQL Server exception handling techniques with proper logging and transaction management.