using UnityEngine;

public class Tutorial7 : MonoBehaviour
{
    void Start()
    {
        //variable declaration
        float x = 0f;
        int myInt = 0;
        // basic operations to 'x' variable
        x = x + 2;
        Debug.Log(x);
        x = x + 2;
        Debug.Log(x);
        // basic operations to 'myInt' variable
        myInt = myInt + 2*2;
        Debug.Log(myInt);
        myInt = myInt*9;
        Debug.Log(myInt);
    }
}