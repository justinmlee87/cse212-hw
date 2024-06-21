public static class Priority
{
    public static void Test()
    {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Demonstrating enqueue
        // Expected Result: Task with lower number should display as the higher priority

        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("Task A", 3); // Lower number indicates higher priority
        priorityQueue.Enqueue("Task B", 1);
        priorityQueue.Enqueue("Task C", 2);

        Console.WriteLine($"Priority Queue after Enqueue: {priorityQueue}");
        Console.WriteLine("Expected Order after Enqueue: Task B (Pri:1), Task C (Pri:2), Task A (Pri:3)");

        // Defect(s) Found: Items initially displayed/stored in the wrong order.

        Console.WriteLine("---------");

        // Test 2
        // Scenario:
        // Expected Result:
        Console.WriteLine("Test 2");
        string result1 = priorityQueue.Dequeue(); // Expected: "Task B"
        string result2 = priorityQueue.Dequeue(); // Expected: "Task C"
        string result3 = priorityQueue.Dequeue(); // Expected: "Task A"

        Console.WriteLine($"Dequeue result 1: {result1}");
        Console.WriteLine($"Dequeue result 2: {result2}");
        Console.WriteLine($"Dequeue result 3: {result3}");

        Console.WriteLine($"Priority Queue after Dequeue: {priorityQueue}");

        // Defect(s) Found: Items not initially dequeued in proper order. 

        Console.WriteLine("---------");


    }
}