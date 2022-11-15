using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    [SerializeField] private float speed;

    [SerializeField] private bool moveRight;



    // Update is called once per frame
    void Update()
    {
        if(moveRight)
        {
            transform.Translate(2*Time.deltaTime*speed,0,0);
        }else{
            transform.Translate(-2*Time.deltaTime*speed,0,0);
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Turn"))
        {
            if(moveRight)
            {
                moveRight=false;
            }else{
                moveRight=true;
            }
        }
    }
}
