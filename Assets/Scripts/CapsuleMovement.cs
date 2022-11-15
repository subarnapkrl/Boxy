using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private bool moveUp;
   
    // Update is called once per frame
    void Update()
    {
        if(moveUp)
        {
            transform.Translate(0,2*Time.deltaTime*speed,0);

        }else{
             transform.Translate(0,-2*Time.deltaTime*speed,0);
        }
    }
     private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Turne"))
        {
            if(moveUp)
            {
                moveUp=false;
            }else{
                moveUp=true;
            }
        }
    }
}

