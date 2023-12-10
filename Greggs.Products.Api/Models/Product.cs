using System;

namespace Greggs.Products.Api.Models;

public class Product
{
    public string Name { get; set; }
    public decimal PriceInPounds { get; set; }
    public decimal PriceInEuros
    {
        get { return Math.Floor(PriceInPounds * 1.11m * 100) / 100; }
    }
}