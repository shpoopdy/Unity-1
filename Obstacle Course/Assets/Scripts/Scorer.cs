using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int bumpCount = 0;
    
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag != "Hit") {
            bumpCount++;
            Debug.Log("You've bumped into a thing this many times: " + bumpCount);
        }
   }
}
