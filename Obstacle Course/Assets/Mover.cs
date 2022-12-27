using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;
    // Start is called before the first frame update
    void Start() {
        PrintInstruction();
    }

    // Update is called once per frame
    void Update() {
        MovePlayer();
    }

    void PrintInstruction() {
        Debug.Log("Howdy hey.");
        Debug.Log("To play use W,A,S,D.");
        Debug.Log("No matter what, you smell.");
    }

    void MovePlayer() {
        float xValue = (Input.GetAxis("Horizontal") * Time.deltaTime) * moveSpeed;
        float zValue = (Input.GetAxis("Vertical") * Time.deltaTime) * moveSpeed;
        transform.Translate(xValue, 0, zValue);
    }
}
