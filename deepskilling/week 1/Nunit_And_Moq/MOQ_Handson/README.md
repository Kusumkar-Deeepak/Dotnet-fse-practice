# Moq Handson - NUnit and Moq Unit Testing

## Overview

This handson demonstrates how to perform Unit Testing using **NUnit** and **Moq** by mocking external dependencies such as mail servers, file systems, and databases.

## Objectives

- Understand the concept of Mocking in Unit Testing.
- Learn Dependency Injection (DI) for testable code.
- Use Moq framework to create mock objects.
- Write and execute unit tests using NUnit.

## Tasks Implemented

### Task 1: Mock Mail Server

**Projects:**

- CustomerCommLib
- CustomerComm.Tests

**Description:**
Created a testable mail communication module by mocking the `IMailSender` dependency to avoid sending real emails during testing.

---

### Task 2: Mock File System

**Projects:**

- MagicFilesLib
- DirectoryExplorer.Tests

**Description:**
Implemented file retrieval functionality and mocked file system access using `IDirectoryExplorer` for unit testing.

---

### Task 3: Mock Database Access

**Projects:**

- PlayersManagerLib
- PlayerManager.Tests

**Description:**
Developed player registration functionality and mocked database interactions using `IPlayerMapper` to test business logic independently.

## Technologies Used

- C#
- .NET
- NUnit
- Moq
- Visual Studio 2022

## How to Run

### Build the Solution

````bash
dotnet build

```bash
dotnet test

## Test Results

All unit tests executed successfully.

| Metric | Count |
|--------|-------|
| Total Tests | 3 |
| Passed | 3 |
| Failed | 0 |

### Summary

```text
Total Tests : 3
Passed      : 3
Failed      : 0
````
