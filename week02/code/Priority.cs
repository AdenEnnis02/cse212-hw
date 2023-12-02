/*
 * CSE212 
 * (c) BYU-Idaho
 * 02-Prove - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */
using System.ComponentModel;
using System.Diagnostics;

public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: 
        // Expected Result: 
        Console.WriteLine("Test 1");
        var queue = new TakingTurnsQueue();
        
        queue.AddPerson("John", 3);

        Trace.Assert(queue.Length == 1, "Adding a person should increment the queue length.");
        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Test 2
        // Scenario: 
        // Expected Result: 
        Console.WriteLine("Test 2");

        queue.AddPerson("Alice", 2);

        queue.GetNextPerson();

        Trace.Assert(queue.Length == 1, "Getting the next person should decrement turns but not remove them from the queue.");
        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
        queue.AddPerson("Bob", 0);

        queue.GetNextPerson();

        Trace.Assert(queue.Length == 1, "Getting the next person with zero turns should move them to the back of the queue.");

    }
}