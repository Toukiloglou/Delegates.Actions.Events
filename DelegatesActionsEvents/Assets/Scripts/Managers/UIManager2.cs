using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager2 : MonoBehaviour
{
    private Text _healthText;

    public void OnEnable() {
        PlayerAction.onDamageReceived += UpdateHealth;
    }

    void Start()
    {
        _healthText = this.transform.GetChild(0).GetComponent<Text>();
    }

    public void UpdateHealth(int health) {
        _healthText.text = "Health : " + health.ToString();
    }
}
