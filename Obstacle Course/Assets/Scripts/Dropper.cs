using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigiddy;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = false;

        rigiddy = GetComponent<Rigidbody>();
        rigiddy.useGravity = false;
    }

    [SerializeField] float waitTime = 5f;
    // Update is called once per frame
    void Update() {
        if (Time.time > waitTime) {
            renderer.enabled = true;
            rigiddy.useGravity = true;
        }
    }
}
