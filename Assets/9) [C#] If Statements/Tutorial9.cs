using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial9 : MonoBehaviour
{
    void Start()
    {
        // Nested If
        if (true)
        {
            Debug.Log("1st");
            if (false)
            {
                Debug.Log("2nd");
            }
        }


        // 2 Unrelated Ifs & Single Line Ifs
        if (true) Debug.Log("IF A");
        else if (true) Debug.Log("IF-ELSE A");
        else Debug.Log("ELSE A");


        if (true) Debug.Log("IF B");

        // Code on the Same Line
        if (true)
        {
            Debug.Log("A");
            Debug.Log("B");
            Debug.Log("C");
        }

        // Standard If-Else
        if (false)
        {
            Debug.Log("if");
        }
        else if (true)
        {
            Debug.Log("else if");
        }
        else if (true)
        {
        }
        else if (true)
        {
        }
        else if (true)
        {
        }
        else
        {
            Debug.Log("else");
        }
    }
}