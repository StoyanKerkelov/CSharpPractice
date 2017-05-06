using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class StringBuilderExtensions
{
    public static StringBuilder Substring(this StringBuilder str, int index, int length)
    {
        StringBuilder result = new StringBuilder();

        for (int counter = index; counter < index + length; counter++)
        {
            result.Append(str[counter]);
        }

        return result;
    }
}
