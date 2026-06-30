using System;

// Product Interface
interface IDocument
{
    void Open();
}

// Concrete Products

class WordDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("Opening Word Document");
    }
}

class PdfDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("Opening PDF Document");
    }
}

class ExcelDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("Opening Excel Document");
    }
}

// Factory Interface

interface IDocumentFactory
{
    IDocument CreateDocument(string type);
}

// Concrete Factory

class DocumentFactory : IDocumentFactory
{
    public IDocument CreateDocument(string type)
    {
        switch (type.ToLower())
        {
            case "word":
                return new WordDocument();

            case "pdf":
                return new PdfDocument();

            case "excel":
                return new ExcelDocument();

            default:
                Console.WriteLine("Invalid Document Type");
                return null;
        }
    }
}

// Client

class Program
{
    static void Main(string[] args)
    {
        string type = "word";

        IDocumentFactory factory = new DocumentFactory();

        IDocument document = factory.CreateDocument(type);

        if (document != null)
        {
            document.Open();
        }

        Console.ReadKey();
    }
}