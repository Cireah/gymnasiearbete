using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideandshowinfo : MonoBehaviour
{
    public GameObject prompt;
    public GameObject text;
    bool enteredarea;
    void Start()
    {
        enteredarea = false;
        prompt.SetActive(false);
        text.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown("e") && enteredarea == true)
        {
            text.SetActive(true);
            prompt.SetActive(false);
        }
    }

    public void OnTriggerEnter2D(Collider2D areadetect)
    {
        prompt.SetActive(true);
        enteredarea = true;
        
    }

    public void OnTriggerExit2D(Collider2D areadetect)
    {
        Start();
    }

    public void HideInfo()
    {
        text.SetActive(false);
        prompt.SetActive(true);
    }
}
