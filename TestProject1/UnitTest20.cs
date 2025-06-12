using System;

namespace MyApp.Test;

public class UnitTest20
{
    [Theory]
    [InlineData("()")]
    [InlineData("()[]{}")]
    [InlineData("([])")]
    public void TestExercise20True(string value)
    {
        //arrange

        //act
        bool t = new Exercise20().Run(value);

        //Assert
        Assert.True(t);
    }

    [Theory]
    [InlineData("(]")]
    [InlineData("([)]")]
    [InlineData("({{{{}}}))")]
    [InlineData("[([]])")]
    public void TestExercise20False(string value)
    {
        //arrange

        //act
        bool t = new Exercise20().Run(value);

        //Assert
        Assert.False(t);
    }
}
