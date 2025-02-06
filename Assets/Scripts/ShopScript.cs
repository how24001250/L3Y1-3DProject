using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopScript : MonoBehaviour
{      
    public int boostPurchased;
    public TextMeshProUGUI boostPurchasedText;

    private void Update() {
        boostPurchasedText.text = boostPurchased.ToString();
    }

    public void BoostPurchased() 
    {
        if(GameObject.Find("GameManager").GetComponent<GameManager>().collectables >= 1) 
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().SubtractCoin();
            GameObject.Find("Car").GetComponent<CarController>().SpeedBoostPurchased();

            boostPurchased++;

        }
        else{
            Debug.Log("Unable to validate purchase");
        }
    }
    public void TimePurchased() 
    {
        if(GameObject.Find("GameManager").GetComponent<GameManager>().collectables >= 1) 
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().SubtractCoin();
            GameObject.Find("GameManager").GetComponent<GameManager>().TimePurchased();
        }
        else{
            Debug.Log("Unable to validate purchase");
        }
    }
}
