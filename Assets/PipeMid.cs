using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMid : MonoBehaviour
{
    public Logic logScript;
    
    // Start is called before the first frame update
    void Start()
    {
        logScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logScript.addScore(1);
        }
        
    }
}
