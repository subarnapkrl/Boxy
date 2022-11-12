using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D _rb;
    
    [SerializeField]float _speed=10f;

    float _inputHorizontal;
    float _inputVertical;

    // Start is called before the first frame update
    void Start()
    {
       _rb=gameObject.GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
        _inputHorizontal=Input.GetAxisRaw("Horizontal");
        _inputVertical=Input.GetAxisRaw("Vertical");

        if(_inputHorizontal!=0)
        {
            _rb.AddForce(new Vector2(_inputHorizontal*_speed,0f));
        }
        if(_inputVertical!=0){
            _rb.AddForce(new Vector2(0f,_inputVertical*_speed));
        }
    }
}
