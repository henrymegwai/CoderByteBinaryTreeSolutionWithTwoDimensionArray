// See https://aka.ms/new-console-template for more information



using System;
using System.Collections.Generic;


    static bool TreeConstructor(string[] strArr)
    {

    Dictionary<string, List<string>> parents = new Dictionary<string, List<string>>();
    Dictionary<string, string> children = new Dictionary<string, string>();

    for (int i = 0; i < strArr.Length; i++)
    {
        string[] pair = strArr[i].Replace("(", "").Replace(")", "").Split(",");
        string child = pair[0];
        string parent = pair[1];

        if (parents.ContainsKey(parent))
        {
            parents[parent].Add(child);
        }
        else
        {
            parents[parent] = new List<string> { child };
        }

        if (parents[parent].Count > 2)
        {
            return false;
        }

        if (children.ContainsKey(child))
        {
            return false;
        }
        else
        {
            children[child] = parent;
        }
    }

    return true;
}




var array1 = new string[] { "(1,2)", "(2,4)", "(5,7)", "(7,2)", "(9,5)" };
var array2 = new string[] { "(1,2)", "(3,2)", "(2,12)", "(5,2)" };
// Test cases
Console.WriteLine(TreeConstructor(array1)); // true
Console.WriteLine(TreeConstructor(array2)); // false
Console.WriteLine(TreeConstructor(new string[] { "(1,2)", "(2,3)", "(3,4)", "(4,5)" })); // true

Console.ReadLine();