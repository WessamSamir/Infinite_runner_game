using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CollectCoins : MonoBehaviour
{
    int coinValue = 0; 
    [SerializeField] AudioSource CoinCollector;
    [SerializeField] TextMeshProUGUI CoinCount;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            CoinCollector.Play();
            coinValue += 1;
            Destroy(other.gameObject);
            CoinCount.text = "Coins:" +" "+ coinValue.ToString();

        }
        
    }
    
}
