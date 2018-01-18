using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial17 : MonoBehaviour {	
	void Start ()
	{
        // while loop
	    int number = 0;
        while (number < 50)
	    {
	        Debug.Log("while loop");
	        number++;
	    }

        // do-while loop
	    number = 0;
	    do
	    {
	        Debug.Log("do loop");
	        number++; 
	    } while (number < 50);

        // for loop
	    for (double i = 0, x = 0; i < 50 && x < 60; i++, x += 2)
	    {
	        Debug.Log("for loop");
	        Debug.Log(x);
	    }

        // infinite for loop (break & continue)
	    for (;;)
	    {
	        Debug.Log("infinite for loop");
	        number++;
            if(100 < number) break;
            continue;
            Debug.Log("continue");
	    }

        // foreach loop
	    int[] ints2 = {1, 2, 3, 4, 5, 6, 7, 8, 9};
	    foreach (int myInt in ints2)
	    {
            Debug.Log(myInt * 2);
	    }

	    BasicClass17[] basicClass17s = new[]
	    {
	        new BasicClass17(1), new BasicClass17(2), new BasicClass17(3), new BasicClass17(4),
            new BasicClass17(5), new BasicClass17(6), new BasicClass17(7), new BasicClass17(8),
            new BasicClass17(9)
	    };

	    foreach (var basicClass17 in basicClass17s)
	    {
	        basicClass17.MyInt *= 2;
            Debug.Log(basicClass17.MyInt);
	    }


        // for loop (arrays)
	    int[] ints = {1, 2, 3, 4, 5, 6, 7, 8, 9};
	    for (int i = 0; i < ints.Length; i++)
	    {
	        ints[i] *= i;
            Debug.Log(ints[i]);
	    }
	}
}

class BasicClass17
{
    public BasicClass17(int myInt)
    {
        MyInt = myInt;
    }

    public int MyInt { get; set; }
}