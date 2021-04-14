using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p2 : MonoBehaviour
{

    public float moveSpeed2 = 500;
    public float turnSpeed2 = 10;
    // Start is called before the first frame update
    void Start()
    {


    }

    private void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal2");
        float z = Input.GetAxis("Vertical2");

        Rigidbody rigidbody2 = GetComponent<Rigidbody>();
        Transform transform2 = GetComponent<Transform>();

        if (x == 0 && z == 0)
        {
            rigidbody2.velocity = new Vector3(0, rigidbody2.velocity.y, 0);
            rigidbody2.angularVelocity = Vector3.zero;


        }
        else
        {
            rigidbody2.AddForce(x * moveSpeed2, 0, z * moveSpeed2);

            float degree = 90 - (Mathf.Atan2(z, x) * 180 / Mathf.PI);
            Quaternion dest_quat = Quaternion.Euler(0, degree, 0);
            Quaternion curr_quat = transform2.rotation;
            transform.rotation = Quaternion.RotateTowards(curr_quat, dest_quat, turnSpeed2);


        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
