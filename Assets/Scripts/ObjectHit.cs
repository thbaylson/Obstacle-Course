using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private bool notHit = true;

    private void OnCollisionEnter(Collision other) 
    {
        if(notHit && other.gameObject.tag == "Player"){
            notHit = false;
            GetComponent<MeshRenderer>().material.color = new Color(255f, 0f, 0f, 1f);
            gameObject.tag = "Hit";
        }
    }
}
