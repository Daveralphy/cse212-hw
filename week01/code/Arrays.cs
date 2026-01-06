public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Plan:
        // 1. Create a new array of doubles with size 'length'.
        // 2. Loop from index 0 up to length - 1.
        // 3. Inside the loop, calculate the multiple: number * (index + 1).
        // 4. Assign the calculated value to the array at the current index.
        // 5. Return the populated array.

        double[] result = new double[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Plan:
        // 1. Determine the split point. We want to move the last 'amount' items to the front.
        //    The index where the "tail" starts is: data.Count - amount.
        // 2. Extract the "tail" portion (the items moving to the front) using GetRange.
        //    Start index: data.Count - amount, Count: amount.
        // 3. Extract the "head" portion (the items moving to the back) using GetRange.
        //    Start index: 0, Count: data.Count - amount.
        // 4. Clear the original 'data' list to prepare for re-insertion.
        // 5. Add the "tail" items back into 'data' first.
        // 6. Add the "head" items back into 'data' second.

        int splitIndex = data.Count - amount;
        List<int> tail = data.GetRange(splitIndex, amount);
        List<int> head = data.GetRange(0, splitIndex);

        data.Clear();
        data.AddRange(tail);
        data.AddRange(head);
    }
}
