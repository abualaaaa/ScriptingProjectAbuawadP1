using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foreachloop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] strings = new string[3];

        strings[0] = "First String";
        strings[1] = "Second String";
        strings[2] = "Third String";

        foreach (string item in strings)
        {
            print (item);
        }
    }
}
    


