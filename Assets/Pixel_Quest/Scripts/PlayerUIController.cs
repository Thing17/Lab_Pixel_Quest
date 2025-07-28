using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUIController : MonoBehaviour
{
    public Image heartImage;
    public TextMeshProUGUI coinText;

    public void Start()
    {
        heartImage = GameObject.Find("HeartImage").GetComponent<Image>();
        coinText = GameObject.Find("CoinText").GetComponent <TextMeshProUGUI>();
    }

    public void UpdateHealth(float currentHealth, float maxHealth)
    {
        heartImage.fillAmount = currentHealth / maxHealth;
    }

    public void UpdateCoinText(string newText)
    {
        coinText.text = newText;
    }
}
