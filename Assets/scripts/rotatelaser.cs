using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class rotatelaser : MonoBehaviour
{
    public GameObject inputfield;
    public TMP_InputField inputfieldy;
    public Rigidbody2D Player;
    public GameObject door;

    [SerializeField] private bool triggerActive = false;


    void Start()
    {
        inputfield.SetActive(false);
        door.SetActive(false);
    }
    
    public void OnTriggerEnter2D(Collider2D copiaplush)
    {
        if (copiaplush.CompareTag("Player"))
        {
            triggerActive = true;
            inputfield.SetActive(true);
        }
    }

    public void OnTriggerExit2D(Collider2D copiaplush)
    {
        if (copiaplush.CompareTag("Player"))
        {
            triggerActive = false;
            inputfield.SetActive(false);
        }
    }

    private void FixedUpdate()
    {
        if (triggerActive == true)
        {
            ReadStringInput();
        }
    }

    public void ReadStringInput()
    {
        string text = inputfield.GetComponent<TMP_InputField>().text;

        if (text == "among us")
        {
            inputfieldy.text = "";
            transform.Rotate(Vector3.forward, 90);

            Player.constraints = RigidbodyConstraints2D.None;
            Player.constraints = RigidbodyConstraints2D.FreezeRotation;
            door.SetActive(true);
        }
    }
}
