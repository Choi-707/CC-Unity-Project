using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if we enter a collision and the object we collided with is tagged enemy
        // destroy the game object we hit
        if (collision.gameObject.tag == "enemy")
            {
            Destroy(collision.gameObject);
            Debug.Log("Destroyed");
        }
    }
}
