using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial4 : MonoBehaviour
{
    void Start()
    {
        // ints
        Debug.Log(123);
        Debug.Log(1000);
        Debug.Log(-256);

        // floats
        Debug.Log(3.5F);
        Debug.Log(123456719f);

        // doubles
        Debug.Log(1.234567890123456789);
        Debug.Log(1.23456D);
        Debug.Log(123456789d);

        // bools
        Debug.Log(true);
        Debug.Log(false);

        // strings
        Debug.Log("string");
        Debug.Log("my text");

        // ToString Method
        Debug.Log("string".ToString());
    }
}