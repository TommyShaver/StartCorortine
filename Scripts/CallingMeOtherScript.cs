using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallingMeOtherScript : MonoBehaviour
{
    private TestCorotines _testScript;

    private void Start()
    {
        _testScript = GameObject.Find("Square").GetComponent<TestCorotines>();
    }
    private void OnMouseEnter()
    {
        _testScript.StartTimer(5);
    }

    private void OnMouseExit()
    {
        _testScript.StartTimer(7);
    }
}
