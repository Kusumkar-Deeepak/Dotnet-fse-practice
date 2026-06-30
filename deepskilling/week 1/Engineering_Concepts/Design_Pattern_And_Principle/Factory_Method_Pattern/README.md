# Factory Method Pattern Example

## Objective

To implement the Factory Method Design Pattern for creating different types of documents in a document management system.

## Scenario

A document management system needs to create different types of documents such as Word, PDF, and Excel documents.

## Technologies Used

- C#
- .NET Console Application
- Visual Studio 2022

## Classes Used

### Product Interface

- IDocument

### Concrete Products

- WordDocument
- PdfDocument
- ExcelDocument

### Factory Interface

- IDocumentFactory

### Concrete Factory

- DocumentFactory

## Working

1. The client requests a document type.
2. The factory receives the document type.
3. The factory creates the required document object.
4. The client uses the created object without knowing its implementation details.

## Benefits of Factory Method Pattern

- Reduces object creation complexity.
- Promotes loose coupling.
- Makes code easy to maintain.
- Supports Open/Closed Principle.
- Improves code reusability.

## Sample Output

Opening PDF Document

## Conclusion

Successfully implemented the Factory Method Pattern to create different document objects dynamically.
