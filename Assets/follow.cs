using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{

    public GameObject target;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = GetComponent<Transform>().position - target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Transform>().position = target.transform.position + offset;
    }
}
