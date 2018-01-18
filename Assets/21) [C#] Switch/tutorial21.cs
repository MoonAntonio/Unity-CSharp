using System;
using UnityEngine;

public class tutorial21 : MonoBehaviour
{
    private void Start()
    {
        var number = 3;
        switch (number)
        {
            case 0:
            case 1:
                caseZeroMethod();
                break;
            case 2:
                "case 2".Log();
                caseZeroMethod();
                return;
            case 100:
                break;
            default:
                "default".Log();
                break;
        }

        var  day = Days.Monday;
        switch (day)
        {
            case Days.Monday:
            case Days.Tuesday:
            case Days.Wednesday:
            case Days.Thursday:
            case Days.Friday:
                "weekday".Log();
                break;
            case Days.Saturday:
            case Days.Sunday:
                "weekend".Log();
                break;
        }
    }

    private static void caseZeroMethod()
    {
        "hello".Log();
    }
}