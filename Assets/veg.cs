using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class veg : MonoBehaviour
{

    void OnTriggerEnter(Collider hit)
    {
        if (hit.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
