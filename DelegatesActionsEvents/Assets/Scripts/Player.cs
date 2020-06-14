using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public delegate void OnDeath();
    public static event OnDeath onDeath;

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            Death();
        }
    }


    void Death() {
        // if some class has registered the event, run the associated function
        if(onDeath != null) {
            onDeath();
        }
    }
}
