using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial12 : MonoBehaviour
{
    void Start()
    {
        method();
        log();
        int i = log(10);
        log(0);
        log("a string", 0);
        log("another string", 10);
    }
    
    // METHOD DECLARATION 
    /*Access Modifier*/ private /*Other Modifiers*/ /*Return Type*/void /*Method Name*/method (/*Parameters*/)
    {
        /*Method Body*/
    }

    // Overloading 'log' method
    void log()
    {
        if(true)return;
        Debug.Log("simple message");
    }

    int log(int i)
    {
        if (true) return 10;
        return 0;
    }

    void log(string str, int i)
    {
        Debug.Log(str);
        Debug.Log(i);
    }

    void log(string str1, string str2) { }
}