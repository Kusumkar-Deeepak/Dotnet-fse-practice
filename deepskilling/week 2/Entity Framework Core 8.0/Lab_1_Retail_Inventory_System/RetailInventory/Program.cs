using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;

using var context = new AppDbContext();

Console.WriteLine("===== LAB 6 : UPDATE PRODUCT =====");

// Update Laptop Price
var product = await context.Products
                           .FirstOrDefaultAsync(p => p.Name == "Laptop");

if (product != null)
{
    Console.WriteLine($"Old Price of {product.Name}: ₹{product.Price}");

    product.Price = 70000;

    await context.SaveChangesAsync();

    Console.WriteLine($"New Price of {product.Name}: ₹{product.Price}");
}
else
{
    Console.WriteLine("Laptop not found.");
}

Console.WriteLine("\n===== LAB 6 : DELETE PRODUCT =====");

// Delete Rice Bag
var toDelete = await context.Products
                            .FirstOrDefaultAsync(p => p.Name == "Rice Bag");

if (toDelete != null)
{
    context.Products.Remove(toDelete);

    await context.SaveChangesAsync();

    Console.WriteLine($"Product '{toDelete.Name}' deleted successfully.");
}
else
{
    Console.WriteLine("Rice Bag not found.");
}

Console.WriteLine("\n===== REMAINING PRODUCTS =====");

var products = await context.Products.ToListAsync();

foreach (var p in products)
{
    Console.WriteLine($"{p.Id} - {p.Name} - ₹{p.Price}");
}