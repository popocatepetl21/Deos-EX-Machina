using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kutaleni : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        moveLeft();
        moveRight();
    }

    void moveLeft()
    {
        if(Input.GetKey(KeyCode.A))
        {
            rigidbody.AddRelativeForce(-speed * Time.deltaTime, 0,0 );
        }
    }
    void moveRight()
    {
         if(Input.GetKey(KeyCode.D))
        {
            rigidbody.AddRelativeForce(speed * Time.deltaTime, 0, 0);
        }
    }
    
}
