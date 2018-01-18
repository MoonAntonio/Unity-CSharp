using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial20 : MonoBehaviour {
	void Start ()
	{
	    var day = Days.Friday;
	    "{0}".Log(day);
	    "{0}".Log((int) day);
	    "{0}".Log((Days) 3);

	    "{0}".Log((int)Days.Monday);
	    "{0}".Log((int)Days.Tuesday);
	    "{0}".Log((int)Days.Wednesday);
	    "{0}".Log((int)Days.Thursday);
	    "{0}".Log((int)Days.Friday);
	    "{0}".Log((int)Days.Saturday);
	    "{0}".Log((int)Days.Sunday);

	    foreach (var theEnum in Enum.GetValues(typeof(Days)))
	    {
	        "{0}".Log(theEnum);
	    }

	    if (day != Days.Monday)
	    {
	        
	    }
    }
}

public enum Days : int
{
    Monday=1,
    Tuesday,
    Wednesday,
    Thursday=90,
    Friday,
    Saturday,
    Sunday
}