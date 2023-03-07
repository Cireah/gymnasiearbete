using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yesmove : MonoBehaviour
{
    public Rigidbody2D Player;

    public void ReleasePlayer()
    {
        Player.constraints = RigidbodyConstraints2D.None;
        Player.constraints = RigidbodyConstraints2D.FreezeRotation;
    }
}
