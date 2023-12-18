using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Initial array (vector) of elements
        int[] vector = { 1, 2, 2, 3, 4, 4, 4, 5 };

        // Dictionary for counting the quantity of each element
        Dictionary<int, int> elementCounts = new Dictionary<int, int>();

        // Counting the number of each element
        foreach (int element in vector)
        {
            if (elementCounts.ContainsKey(element))
            {
                elementCounts[element]++;
            }
            else
            {
                elementCounts.Add(element, 1);
            }
        }

        // Display messages about duplicate elements
        foreach (KeyValuePair<int, int> kvp in elementCounts)
        {
            if (kvp.Value > 1) // If an element is repeated more than once
            {
                Console.WriteLine($"Element {kvp.Key} repeats itself {kvp.Value} times.");
            }
        }
    }
}
