using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCorotines : MonoBehaviour
{
    
    Coroutine _myCoroutine;

    // Start is called before the first frame update
    void Start()
    {
        _myCoroutine = StartCoroutine(TimerTest(5));
    }

    // Update is called once per frame
    void Update()
    {
      
    }
   
    public void StartTimer(int j)
    {
        
        StartCoroutine(TimerTest(j));
    }

    IEnumerator TimerTest(int _timer)
    {
        int i = 0;
        while(i < _timer)
        {
            i++;
            Debug.Log(i);
           yield return new WaitForSeconds(1);
        }

        Debug.Log("Finish");

    }
}
