using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    private Rigidbody my_rigidbody;
    private bool boost;
    private int draai_body = 0;
    // Start is called before the first frame update
    void Start()
    {
        my_rigidbody = GetComponent<Rigidbody>();
        my_rigidbody.maxAngularVelocity = 10;
    }

    // Update is called once per frame
    void Update()
    {
        boost = Input.GetKey(KeyCode.Space);
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            draai_body = 1;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            draai_body = -1;
        }
        else
        {
            draai_body = 0;
        }
    }
    void FixedUpdate()
    {
        if (boost)
        {
            my_rigidbody.AddRelativeForce(new Vector3(0, 10, 0), ForceMode.Force);
        }

        transform.Rotate(0, 0, draai_body);
    }
}