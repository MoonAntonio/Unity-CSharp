using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial23 : MonoBehaviour {
	void Start () {
		var b = new B(0);
        b.MethodA();
	}
}

public class A
{
    private int _intA;
    protected int proIntA;

    protected void proMethod()
    {
        
    }

    protected int proProp { get; set; }
    public void MethodA()
    {
        "method A".Log();
    }

    public A(int i)
    {
        "constructor A".Log();
    }
}

public class B : A
{
    public void MethodB()
    {
        proIntA = 0;
        proProp = 0;
        proMethod();
    }

    public B(int i) : base(i)
    {
        "constructor B".Log();
    }
}

public class C : B
{
    public void MethodC()
    {
        MethodA();
    }

    public C(int i) : base(i)
    {
    }
}