using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_count : MonoBehaviour
{
    int count_i = 10 - GameObject.FindGameObjectsWithTag("Item").Length;

    
    private void OnTriggerEnter(Collider hit)
    {
        if (hit.CompareTag("Player") && count_i <= 2)
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
