using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial19 : MonoBehaviour {
	void Start () {
		var bc = new BasicClass19();
	    bc[3] = "myString";
	    // get unity-spice for FREE (https://tk2.uk/unity-spice)
        // bc[3].Log();
        Debug.Log(bc[3]);
	    bc[100] = "errorString";
        bc.AttemptAdd(100,"errorString");
	    // bc["value1", "value2"].Log();
	    Debug.Log(bc["value1", "value2"]);

        for (int i = 0; i < bc.Length; i++)
	    {
	        if(bc[i]==null)continue;
	        // "{0} @ {1}".Log(bc[i], i);
	        Debug.Log(bc[i]);
        }
	}
}

public class BasicClass19
{
    private string[] _strings = new string[100];

    public string this[int i]
    {
        get { return _strings[i]; }
        set
        {
            _strings[i] = value;
        }
    }

    public string this[string str, string str2] { get { return ""; } }

    public int Length
    {
        get { return _strings.Length; }
    }

    public void AttemptAdd(int i, string str)
    {
        if (_strings.Length <= i)
        {
            // get unity-spice for FREE (https://tk2.uk/unity-spice)
            // "_strings.Length less than {0}".LogWarning(i);
            Debug.LogWarning("_strings.Length less than i");
            return;
        }
        this[i] = str;
    }
}