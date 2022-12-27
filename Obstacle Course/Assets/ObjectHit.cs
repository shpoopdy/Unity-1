using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
   private void OnCollisionEnter(Collision other) {
        //Debug.Log("OUCH!");
        GetComponent<MeshRenderer>().material.color = Color.blue;
   }
}
