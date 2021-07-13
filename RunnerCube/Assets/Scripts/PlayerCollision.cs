using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerMovement playerMovement;
    void OnCollisionEnter(Collision collisionInfo) {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("We hit a Obstacle");
            playerMovement.enabled = false;
        }
    }
}
