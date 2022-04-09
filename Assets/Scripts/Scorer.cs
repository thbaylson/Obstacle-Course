using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int hits;

    // Start is called before the first frame update
    void Start()
    {
        this.hits = 0;
    }

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag != "Hit"){
            this.hits++;
            Debug.Log("You've bumped into a thing this many times: " + this.hits);
        }
    }
}
