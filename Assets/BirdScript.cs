using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public Logic logScript;
    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "Ambatubird";
        logScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logScript.gameOver();
        birdIsAlive = false;
    }
}
