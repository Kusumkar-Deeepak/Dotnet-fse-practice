using System;

class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string Category { get; set; }

    public Product(int productId, string productName, string category)
    {
        ProductId = productId;
        ProductName = productName;
        Category = category;
    }
}

class EcommerceSearch
{
    // Linear Search
    static Product LinearSearch(Product[] products, int searchId)
    {
        foreach (Product product in products)
        {
            if (product.ProductId == searchId)
            {
                return product;
            }
        }

        return null;
    }

    // Binary Search
    static Product BinarySearch(Product[] products, int searchId)
    {
        int left = 0;
        int right = products.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (products[mid].ProductId == searchId)
            {
                return products[mid];
            }
            else if (products[mid].ProductId < searchId)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return null;
    }

    static void Main()
    {
        // Sorted Array
        Product[] products =
        {
            new Product(101, "Laptop", "Electronics"),
            new Product(102, "Mouse", "Accessories"),
            new Product(103, "Keyboard", "Accessories"),
            new Product(104, "Monitor", "Electronics"),
            new Product(105, "Printer", "Electronics")
        };

        Console.Write("Enter Product ID to Search: ");
        int searchId = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n----- Linear Search -----");

        Product linearResult = LinearSearch(products, searchId);

        if (linearResult != null)
        {
            Console.WriteLine("Product Found");
            Console.WriteLine("ID: " + linearResult.ProductId);
            Console.WriteLine("Name: " + linearResult.ProductName);
            Console.WriteLine("Category: " + linearResult.Category);
        }
        else
        {
            Console.WriteLine("Product Not Found");
        }

        Console.WriteLine("\n----- Binary Search -----");

        Product binaryResult = BinarySearch(products, searchId);

        if (binaryResult != null)
        {
            Console.WriteLine("Product Found");
            Console.WriteLine("ID: " + binaryResult.ProductId);
            Console.WriteLine("Name: " + binaryResult.ProductName);
            Console.WriteLine("Category: " + binaryResult.Category);
        }
        else
        {
            Console.WriteLine("Product Not Found");
        }
    }
}