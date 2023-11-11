// See https://aka.ms/new-console-template for more information

/* 
Big O notation: The concern is the bottle neck, which is the for loop. 

Time complexity: 0(n * m) => 0(n ^ 2), n is the length of the array and m is the length of the substring.

Space complexity will be 0(n), since the number of set keys and corresponding values for the Dictionaries depends on the length of the array, and iterations on the array by the for loop
*/



static bool TreeConstructor(string[] strArr)
{

    // code goes here  

    Dictionary<string, List<string>> parents = new Dictionary<string, List<string>>(); // Time Complexity: 0(1), Space Complexity: 0(n)
    Dictionary<string, string> children = new Dictionary<string, string>(); // Time Complexity: 0(1), Space Complexity: 0(n)


    for (int i = 0; i < strArr.Length; i++) // Time complexity is linear: 0(n). Space Complexity: 0(n), n is the number of length of the array
    {
        string[] cleanedData = strArr[i].Replace("(", "").Replace(")", "").Split(","); //Time Complexity 0(m), Space Complexity: 0(m), m is the lenght of the substrings
        string child = cleanedData[0];
        string parent = cleanedData[1];

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





