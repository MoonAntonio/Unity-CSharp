using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial13 : MonoBehaviour {
	void Start () {
		door frontDoor = new door();
        frontDoor.Close();
        frontDoor.Open();
	    frontDoor.Open();

    }
}


/*Access Modifier*/internal /*Other Modifiers*/ /*'class' keyword*/class /*Name of Class*/class1
{
    // CONSTRUCTOR
    /*Access Modifier*/public /*Name of Class*/ class1( /*Parameters*/)
    {
        
    }

    // overloaded constructor
    public class1(int i)
    {
        
    }
}

class door
{
    private bool _isOpen=false;

    // overriding the default constructor
    public door()
    {
        _isOpen = true;
    }

    public door(bool isOpen)
    {
        _isOpen = isOpen;
    }

    public void Open()
    {
        if (_isOpen) Debug.Log("door is already open");
        else
        {
            _isOpen = true;
            Debug.Log("door has been opened");
        }
    }
    public void Close()
    {
        if (!_isOpen)
        {
            Debug.Log("door is already closed");
            return;
        }
        _isOpen = false;
        Debug.Log("door has been closed");
    }
}