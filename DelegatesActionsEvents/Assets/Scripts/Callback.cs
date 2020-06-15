using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Callback : MonoBehaviour
{
    
    void Start()
    {
        StartCoroutine(MyRoutine( () => {
            Debug.Log("The routine has finished");
        }));
    }

    public IEnumerator MyRoutine(Action onComplete = null) {

        yield return new WaitForSeconds(5f);

        if(onComplete != null) {
            onComplete();
        }

    }
}
