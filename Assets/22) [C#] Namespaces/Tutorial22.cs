using System.Collections;
using System.Collections.Generic;
using MyNamespace;
using an = MyNamespace.AnotherNamespace;
using UnityEngine;

public class Tutorial22 : MonoBehaviour {
	void Start () {
        // var obj = new MyNamespace.BasicClass22();
        var obj = new BasicClass22();
	    var obj2 = new an.MyClass22();
	}
}

namespace MyNamespace
{
    public class BasicClass22 { }

    namespace AnotherNamespace
    {
        public class MyClass22 { }
    }
}

namespace MyNamespace.AnotherNamespace
{
    public class MyNewClass22
    {
    
    }
}

public class MyClass22
{
    public class System { }
    public int Console { get; set; }

    public void Log()
    {
        global::System.Console.WriteLine("");
    }
}