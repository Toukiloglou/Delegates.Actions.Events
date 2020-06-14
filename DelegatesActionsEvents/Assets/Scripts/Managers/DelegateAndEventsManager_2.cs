using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateAndEventsManager_2 : MonoBehaviour
{

    private void OnEnable() {
        Player.onDeath += ResetPlayer;
    }


    public void ResetPlayer() {
        Debug.Log("Reseting player...");
    }
}
