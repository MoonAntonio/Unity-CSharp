using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial5 : MonoBehaviour
{
    void Start()
    {
        // '+' Operator
        Debug.Log(+123);
        Debug.Log(+123.456f);
        Debug.Log(+123.456d);

        // '-' Operator
        Debug.Log(-123);
        Debug.Log(-123.456f);
        Debug.Log(-123.456d);

        Debug.Log(+-123);
        Debug.Log(-+123);

        // '!' or 'NOT' Operator
        Debug.Log(!true);
        Debug.Log(!false);
    }
}