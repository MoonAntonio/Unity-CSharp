using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial15 : MonoBehaviour {

    BasicClass15 _obj;

    private BasicClass15 Obj
    {
        // Lazy Initialization from Property
        get { return _obj ?? (_obj = new BasicClass15()); }
    }
    void Start () {
        // Reference Objects
        BasicClass15 myClass = new BasicClass15();
        BasicClass15 myClass2 = myClass;
        myClass2.MyInt = 10;
        Debug.Log(myClass.MyInt);
        Debug.Log(myClass2.MyInt);

        // Value Objects (Structs)
        Vector3 myVector3 = new Vector3(1,2,3);
        Vector3 myNewVector3 = myVector3;
        myNewVector3.x = 20;
        Debug.Log(myVector3.x);
        Debug.Log(myNewVector3.x);

        // Causes "Null Reference Exception" when uncommented
        // Debug.Log(_obj.MyInt); 

        // Lazy "obj2" Initialization
        BasicClass15 obj2 = null;
        if (obj2 == null) obj2 = new BasicClass15();
        Debug.Log(obj2.MyInt);

        // Nullable Object
        int? myInt = 0;
        myInt = 10;
        Debug.Log(myInt+10);
        myInt = null;
        Debug.Log(myInt+10);
        Debug.Log(myInt.HasValue);

        // Other Nullable Object Examples
        int myOtherInt = 10;
        if (myInt == null) myInt = 0;
        if(myInt.HasValue || myInt != null) myOtherInt = myInt.Value;
        Debug.Log(myOtherInt);
    }
}

public class BasicClass15
{
    public int MyInt;
}