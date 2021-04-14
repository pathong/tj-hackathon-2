using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p1con : MonoBehaviour
{
    private Animator animator;
    public float moveSpeed = 500;
    public float turnSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    private void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Rigidbody rigidbody = GetComponent<Rigidbody>();
        Transform transform = GetComponent<Transform>();

        if(x == 0 && z == 0)
        {
            rigidbody.velocity = new Vector3(0, rigidbody.velocity.y, 0);
            rigidbody.angularVelocity = Vector3.zero;
            animator.SetBool("is_walk", false);

        }
        else
        {
            rigidbody.AddForce(x * moveSpeed, 0, z * moveSpeed);

            float degree = 90 - (Mathf.Atan2(z, x) * 180 / Mathf.PI);
            Quaternion dest_quat = Quaternion.Euler(0, degree, 0);
            Quaternion curr_quat = transform.rotation;
            transform.rotation = Quaternion.RotateTowards(curr_quat, dest_quat, turnSpeed);

            animator.SetBool("is_walk", true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
