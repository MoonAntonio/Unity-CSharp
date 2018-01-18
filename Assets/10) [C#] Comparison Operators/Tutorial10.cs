using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial10 : MonoBehaviour
{
    void Start()
    {
        // Relational Operators
        Debug.Log(4 < 8);
        Debug.Log(4 > 8);
        Debug.Log(4 <= 8);
        Debug.Log(8 <= 8);
        Debug.Log(4 >= 8);
        // - Example
        if (4 < 8) { }

        // Assignment Operator
        int x = 0;
        Debug.Log(x = 9);

        // Equality Operators
        Debug.Log(x == 9);
        Debug.Log(x != 9);

        // BASIC PROGRAM
        int timer = 0;
        Debug.Log(timer);
        if (timer < 2) Debug.Log("under 2");
        if (timer > 3) Debug.Log("above 3");
        if (timer == 1) Debug.Log("equals 1");
        if (timer != 4) Debug.Log("NOT 4");
        timer++;
        Debug.Log(timer);
        if (timer < 2) Debug.Log("under 2");
        if (timer > 3) Debug.Log("above 3");
        if (timer == 1) Debug.Log("equals 1");
        if (timer != 4) Debug.Log("NOT 4");
        timer++;
        Debug.Log(timer);
        if (timer < 2) Debug.Log("under 2");
        if (timer > 3) Debug.Log("above 3");
        if (timer == 1) Debug.Log("equals 1");
        if (timer != 4) Debug.Log("NOT 4");
        timer++;
        Debug.Log(timer);
        if (timer < 2) Debug.Log("under 2");
        if (timer > 3) Debug.Log("above 3");
        if (timer == 1) Debug.Log("equals 1");
        if (timer != 4) Debug.Log("NOT 4");
        timer++;
        Debug.Log(timer);
        if (timer < 2) Debug.Log("under 2");
        if (timer > 3) Debug.Log("above 3");
        if (timer == 1) Debug.Log("equals 1");
        if (timer != 4) Debug.Log("NOT 4");
        timer++;
    }
}