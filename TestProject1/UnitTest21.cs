using static ConsoleApp1.Exercise21;

namespace ConsoleApp1.Test;

public class UnitTest21
{
    [Fact]
    public void TestExercise21()
    {
        //arrange
        ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
        ListNode result = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(4))))));

        //act
        ListNode t = new Exercise21().Run(list1, list2);

        //Assert
        Assert.Equivalent(result, t);
    }
    
    [Fact]
    public void TestExercise21_2()
    {
        //arrange
        ListNode list1 = new ListNode(1);
        ListNode list2 = null;
        ListNode result = new ListNode(1);

        //act
        ListNode t = new Exercise21().Run(list1, list2);

        //Assert
        Assert.Equivalent(result, t);
    }
}
