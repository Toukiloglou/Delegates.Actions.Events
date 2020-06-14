using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDown : MonoBehaviour
{
    
    void Start()
    {
        DeligateAndEventsManager_1.onClick += Fall;
    }

    public void Fall() {
        this.GetComponent<Rigidbody>().useGravity = true;
    }

    private void OnDisable() {
        DeligateAndEventsManager_1.onClick -= Fall;
    }

}
