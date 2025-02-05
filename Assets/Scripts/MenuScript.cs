using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public TextMeshProUGUI finalPackagesDelivered;

    private void Update()
    {
        finalPackagesDelivered.text = "You Delivered: " + GameManager.packagesDelivered.ToString();
    }

    public void OnGameStart()
    {
        SceneManager.LoadScene(1);
    }
    public void OnSettings()
    {
        SceneManager.LoadScene(5);
    }
    public void OnExit()
    {
        Application.Quit();
    }

    public void OnMenu()
    {
        SceneManager.LoadScene(0);
    }
}
