using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("Time")]
    public float timer;
    public float timeLimit;
    public TMP_Text timerText;
    
    [Header("Collectables")]
    public int collectables;
    public TextMeshProUGUI collectableText;
    public TextMeshProUGUI collectableTextPause;

    [Header("Packages")]
    public TextMeshProUGUI packagesText;
    public static int packagesDelivered = 0;
    public int amountOfDropOffs = 6;
    
    // Start is called before the first frame update
    void Start()
    {
        timer = timeLimit;
        packagesDelivered = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timerText.text = timer.ToString("F0");
        packagesText.text = packagesDelivered.ToString();

        collectableText.text = collectables.ToString();
        collectableTextPause.text = collectables.ToString();

        

        if (timer <= 0) {
            SceneManager.LoadScene(3);
        }
        else{
            timer -= Time.deltaTime;
        }

        if(packagesDelivered == amountOfDropOffs) {
            SceneManager.LoadScene(3);
        }
    }

    public void SubtractCoin() {
        collectables = collectables - 1;
    }

    public void TimePurchased() 
    {
        timer = timer + 30;
    }
}
