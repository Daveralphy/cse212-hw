using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add items with different priorities and verify they are dequeued in the correct order.
    // Also verify that items with the same priority are dequeued in FIFO order.
    // Expected Result: High1, High2, Mid, Low
    // Defect(s) Found: 
    // 1. The loop in Dequeue was skipping the last item in the queue.
    // 2. The comparison used >= which favored the item later in the list (LIFO for ties) instead of > (FIFO for ties).
    // 3. The item was not being removed from the queue after Dequeue.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("High1", 10);
        priorityQueue.Enqueue("Mid", 5);
        priorityQueue.Enqueue("High2", 10);

        Assert.AreEqual("High1", priorityQueue.Dequeue());
        Assert.AreEqual("High2", priorityQueue.Dequeue());
        Assert.AreEqual("Mid", priorityQueue.Dequeue());
        Assert.AreEqual("Low", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Try to dequeue from an empty queue.
    // Expected Result: InvalidOperationException should be thrown.
    // Defect(s) Found: None.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (Exception e)
        {
             Assert.Fail(string.Format("Unexpected exception of type {0} caught: {1}", e.GetType(), e.Message));
        }
    }

    // Add more test cases as needed below.
}