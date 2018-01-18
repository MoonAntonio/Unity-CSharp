using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial11 : MonoBehaviour
{
    void Start()
    {
        // 'AND' Conditional Operators
        Debug.Log("-AND-");
        Debug.Log(true && true);
        Debug.Log(false && true);
        Debug.Log(false && false);
        Debug.Log(1 == 1 && 2 == 2);
        Debug.Log(1 != 1 && 2 == 2);
        Debug.Log(1 != 1 && 2 != 2);

        // 'OR' Conditional Operators
        Debug.Log("-OR-");
        Debug.Log(true || true);
        Debug.Log(false || true);
        Debug.Log(false || false);
        Debug.Log(1 == 1 || 2 == 2);
        Debug.Log(1 != 1 || 2 == 2);
        Debug.Log(1 != 1 || 2 != 2);

        // Complex Conditional Comparisons
        bool a = false;
        bool b = true && false && true;
        bool c = true && true;
        Debug.Log(a || b || c);

        // '&&' in an if statement
        if (true && true)
        {
        }

        // 'AND' Conditional Operator
        Debug.Log(1 == 2 && 2 == 2);
        // 'AND' Logical Operator
        Debug.Log(1 == 2 & 2 == 2);

        // Ternary Operator
        string str = "";
        str = true ? "true" : "false";
        string strA = true ? true ? "true" : "false" : true ? "true" : "false";
    }
}