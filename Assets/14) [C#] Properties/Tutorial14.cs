using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial14 : MonoBehaviour {
	void Start () {
		MySimpleClass myClass = new MySimpleClass();
	    myClass.MyInt = 10;
        Debug.Log(myClass.MyInt);
	}
}

public class MySimpleClass
{
    private int _myInt;

    // Primative 'Getter/Setter' Methods
    // 'Get method
    public int GetMyInt()
    {
        return _myInt;
    }
    // 'Set' Method
    public void SetMyInt(int myInt)
    {
        _myInt = myInt;
    }

    /*Access Modifier*/ public /*Property Type*/ int /*Property Name*/ MyInt
    {
        /*Get Accessor*/
        get
        {
            return _myInt;
        }
        /*Set Accessor*/
        set
        {
            _myInt = value;
        }
    }

    public string MyString { get; set; }
}