using System;
using System.Collections;
using System.Collections.Generic;

public class ToBinaryFilter
{
    public static List<int> ToBinary(List<int> t_input)
    {
        List<int> result = new List<int>();
        if (t_input != null && t_input.Count > 0)
        {
            foreach (int integer in t_input)
            {
                result.Add(Convert.ToInt32(Convert.ToString(integer, 2)));
            }
        }
        return result;
    }
}
