using System;

namespace TGS.Challenge
{
  /*
       Given a zero-based integer array of length N, the equivalence index (i) is the index where the sum of all the items to the left of the index
       are equal to the sum of all the items to the right of the index.

       Constraints: 0 <= N <= 100 000

       Example: Given the following array [1, 2, 3, 4, 5, 7, 8, 10, 12]
       Your program should output "6" because 1 + 2 + 3 + 4 + 5 + 7 = 10 + 12

       If no index exists then output -1

       There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */

    public class EquivalenceIndex
    {
      public int Find(int[] numbers)
      {
            //Declaration
            int index = 0, beforeIndex = 0, afterIndex = 0;

            if (numbers.Length >= 0 && numbers.Length <= 100000)
            {
                //A first loop that keeps track of the left hand side of the index
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (i > 0)
                    {
                        beforeIndex += numbers[i - 1];

                        //A second loop that keeps track of the right hand side of the index
                        for (int z = 0; z < numbers.Length; z++)
                        {
                            if (Array.IndexOf(numbers, numbers[z]) > i)
                            {
                                afterIndex += numbers[z];
                            }
                        }

                        //Compare the two sides and return index that splits these sides
                        if (beforeIndex == afterIndex)
                        {
                            index = i;
                            break;
                        }
                        else
                            index = -1;
                    }
                    //Reset the afterIndex
                    afterIndex = 0;
                }
            }

            return index;
      }
    }
}
