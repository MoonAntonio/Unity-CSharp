using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial6 : MonoBehaviour
{
    void Start()
    {
        // 'Additive' Operators
        Debug.Log(1 + 1.11 + 1.11);
        Debug.Log(1 + 1.11f + 1.11f);

        Debug.Log(1 - 1.11 - 1.11);
        Debug.Log(1 - 1.11f - 1.11f);

        // 'Multiplicative' Operators
        Debug.Log(2*1);
        Debug.Log(2/4f);

        // 'BODMAS' Example
        Debug.Log(1f + 2f - 3f*4f/5f);
        // 3 * 4 = 12
        // 1 + 2 - 12 / 5
        // 12 / 5 = 2.4
        // 1 + 2 - 2.4
        // 1 + 2 = 3
        // 3 - 2.4 = 0.6
    }
}