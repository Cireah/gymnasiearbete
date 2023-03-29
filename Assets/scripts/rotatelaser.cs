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
    public GameObject laser;

    public string answer = "2x";
    public float laserrotation = 50f;
    public float laserhorizontal = 50f;
    public float laservertical = 6f;

    [SerializeField] private bool triggerActive = false;


    void Start()
    {
        inputfield.SetActive(false);
        door.SetActive(false);
    }
    
    public void OnTriggerEnter2D(Collider2D areadetect)
    {
        if (areadetect.CompareTag("Player"))
        {
            triggerActive = true;
            inputfield.SetActive(true);
        }
    }

    public void OnTriggerExit2D(Collider2D areadetect)
    {
        if (areadetect.CompareTag("Player"))
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
        if (text == answer)
        {
            inputfield.GetComponent<TMP_InputField>().text = "";

            laser.transform.Rotate(Vector3.forward, laserrotation);
            laser.transform.position = new Vector3(laserhorizontal, laservertical);
            Player.constraints = RigidbodyConstraints2D.None;
            Player.constraints = RigidbodyConstraints2D.FreezeRotation;
            door.SetActive(true);
        }
    }
}
