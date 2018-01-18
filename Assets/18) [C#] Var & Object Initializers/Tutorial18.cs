using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial18 : MonoBehaviour
{
    void Start()
    {
        // 'var' keyword
        var i = 0;
        MyClassWithAVeryNiceLongName myClassA = new MyClassWithAVeryNiceLongName();
        var myClassB = new MyClassWithAVeryNiceLongName();

        // Object Initializers
        // - older examples
        var myObjA = new BasicClass18("name", 100);
        var myObjB = new BasicClass18();
        myObjB.Name = "name";
        myObjB.Health = 100;
        // - actual
        var myObjC = new BasicClass18{Name = "name", MyFloat = 0.8f};
        // - nullable
        int? myInt = new int?{ };
        Debug.Log(myInt);
    }
}

public class MyClassWithAVeryNiceLongName
{
    
}

public class BasicClass18
{
    public float MyFloat;
    public BasicClass18()
    { }
    public BasicClass18(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public string Name { get; set; }
    public int Health { get; set; }
}