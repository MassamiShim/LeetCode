using Xunit;
using MyApp;

namespace MyApp.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {

    }

    [Fact]
    public void TestExercise1()
    {
        //arrange
        int[] a = { 0, 1 };
        int[] b = { 2, 7, 11, 15 };
        int c = 9;

        //act
        int[] t = new Exercise1().Run(b, c);

        //Assert
        Assert.Equal(a, t);
    }


}
