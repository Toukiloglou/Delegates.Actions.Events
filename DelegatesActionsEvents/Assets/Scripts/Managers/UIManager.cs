using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    
    private int _deathCount = 0;
    private Text _deathCountText;


    public void OnEnable() {
        Player.onDeath += UpdateDeathCount;
    }

    void Start()
    {
        _deathCount = 0;
        _deathCountText = this.transform.GetChild(0).GetComponent<Text>();
    }

    public void UpdateDeathCount() {
        _deathCount++;
        _deathCountText.text = "Death count : " + _deathCount.ToString();
    }
}
