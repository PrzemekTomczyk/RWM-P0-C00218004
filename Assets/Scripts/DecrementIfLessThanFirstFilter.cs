using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecrementIfLessThanFirstFilter
{
    public static float[] DecrementIfLess(float[] t_numberArray)
    {
        for (int i = 0; i < t_numberArray.Length; i++)
        {
            if (t_numberArray[0] > t_numberArray[i])
            {
                t_numberArray[i]--;
            }
        }
        return t_numberArray;
    }
}
