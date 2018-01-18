using UnityEngine;

public class Tutorial8 : MonoBehaviour
{
    private void Start()
    {
        // 'Multiplicative' Operator
        // Modulus '%'
        Debug.Log(5 % 2);
        Debug.Log(4 % 2);
        Debug.Log(125.678 % 8.93);

        // 'Unary' Operators
        // 'Prefix' Operators
        var x = 1;
        Debug.Log(++x);
        Debug.Log(--x);

        // 'Primary' Operators 
        // 'Postfix' Operators
        var y = 1;
        Debug.Log(y++);
        Debug.Log(y--);
        Debug.Log(y);
        var z = 100;
        Debug.Log(z);
        z++;
        Debug.Log(z);

        // 'Assignment' Operators
        var a = 3;
        Debug.Log(a += 3);
        Debug.Log(a -= 3);
        Debug.Log(a *= 2);
        Debug.Log(a /= 2);
        Debug.Log(a %= 4);

        a += x * 2 * 90;
        Debug.Log(a);
    }
}