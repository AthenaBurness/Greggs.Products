using Greggs.Products.Api.Controllers;
using System;
using System.Linq;
using Xunit;

namespace Greggs.Products.UnitTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        throw new NotImplementedException("We have no tests :-(");
    }

    [Fact] 
    public void UserStory1Test()
    {
        //Arange - design pattern for test writing
        var products = new ProductController();
        //Act 
        var result = products.Get(0, 5).ToList();
        //Assert
        Assert.Equal(5, result.Count);
    }

    [Fact] 
    public void UserStory2Test() {
        //Arrange
        var products = new ProductController();
        //Act
        var product1 = products.Get(0, 1).ToList();
        var product2 = products.Get(1, 2).ToList();
        //Assert
        Assert.Equal(product1.First().PriceInPounds * 1.11m, product1.First().PriceInEuros);
        Assert.Equal(product2.First().PriceInPounds * 1.11m, product2.First().PriceInEuros);
    }
}