using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Football : MonoBehaviour
{
    public TextMeshProUGUI scoreBoard;
    public int goals = 0;

    private void OnTriggerEnter(Collider other) 
    {
        goals++;
        scoreBoard.text = goals.ToString();
    }

}
