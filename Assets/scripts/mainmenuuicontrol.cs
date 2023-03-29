using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainmenuuicontrol : MonoBehaviour
{
    public GameObject startButton;
    public GameObject exitButton;
    public GameObject levelButtons;
    public GameObject backButton;
    void Start()
    {
        levelButtons.SetActive(false);
        backButton.SetActive(false);
    }


    public void OnStartClick()
    {
        levelButtons.SetActive(true);
        backButton.SetActive(true);
        startButton.SetActive(false);
        exitButton.SetActive(false);
    }

    public void OnBackClick()
    {
        levelButtons.SetActive(false);
        backButton.SetActive(false);
        startButton.SetActive(true);
        exitButton.SetActive(true);
    }
}
