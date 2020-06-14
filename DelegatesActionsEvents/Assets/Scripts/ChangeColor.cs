using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{

    void Start()
    {
        DeligateAndEventsManager_1.onClick += NewColor;
    }

    public void NewColor() {
        this.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
    }

    private void OnDisable() {
        DeligateAndEventsManager_1.onClick -= NewColor;
    }

}
