using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopScript : MonoBehaviour
{
    public int timesBoostPurchased = 0;
    public int maxPurchases = 4;

    public int boostPurchased;
    public int boostPurchasedDisplay;
    public TextMeshProUGUI boostPurchasedText;

    private void Update() {
        boostPurchasedDisplay = maxPurchases - boostPurchased;
        boostPurchasedText.text = boostPurchasedDisplay.ToString();
    }

    public void BoostPurchased() 
    {
        if(GameObject.Find("GameManager").GetComponent<GameManager>().collectables >= 1) 
        {
            if(timesBoostPurchased < maxPurchases)
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().SubtractCoin();
                GameObject.Find("Car").GetComponent<CarController>().SpeedBoostPurchased();

                timesBoostPurchased++;
                boostPurchased++;
            }
            else
            {
                Debug.Log("Over the max purchase limit");
            }
            
            

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
