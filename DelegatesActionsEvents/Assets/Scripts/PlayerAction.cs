using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{

    public static Action<int> onDamageReceived;

    public int Health { get; set; }

    void Start()
    {
        Health = 100;
    }

    void Damage() {
        Health--;
        if(onDamageReceived != null) {
            onDamageReceived(Health);
        }
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            Damage();
        }
    }
}
