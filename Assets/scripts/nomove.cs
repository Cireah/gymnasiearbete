using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nomove : MonoBehaviour
{
    public Rigidbody2D Player;

    public void StopPlayer()
    {
        Player.constraints = RigidbodyConstraints2D.FreezePosition;
    }
}
