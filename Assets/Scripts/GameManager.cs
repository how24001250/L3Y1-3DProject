using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float timer;
    public float timeLimit;
    public TMP_Text timerText;

    public int collectables;
    public TextMeshProUGUI collectableText;
    
    // Start is called before the first frame update
    void Start()
    {
        timer = timeLimit;
    }

    // Update is called once per frame
    void Update()
    {
        timerText.text = timer.ToString("F2");

        collectableText.text = "Coins:" + collectables.ToString();
        

        if (timer <= 0) {
            Debug.Log("DNF");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else{
            timer -= Time.deltaTime;
        }
    }
}
