using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    new MeshRenderer renderer;
    Rigidbody rigidBody;

    [SerializeField] private float timeToWait = 5f;
    private bool suspended = true;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = false;

        rigidBody = GetComponent<Rigidbody>();
        rigidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(suspended && Time.time > timeToWait){
            suspended = false;

            renderer.enabled = true;
            rigidBody.useGravity = true;
        }
    }
}
