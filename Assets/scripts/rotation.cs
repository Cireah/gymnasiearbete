using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    [SerializeField] private bool triggerActive = false;

    public void OnTriggerEnter2D(Collider2D copiaplush)
    {
        if (copiaplush.CompareTag("Player"))
        {
            triggerActive = true;
        }
    }

    public void OnTriggerExit2D(Collider2D copiaplush)
    {
        if (copiaplush.CompareTag("Player"))
        {
            triggerActive = false;
        }
    }

    private void Update()
    {
        if (triggerActive == true)
        {
            Rotate();
        }
    }

    public void Rotate()
    {
        transform.Rotate(Vector3.forward, 90);
    }
}