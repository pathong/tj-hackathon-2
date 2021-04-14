using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class sc : MonoBehaviour
{
    public GameObject canvas1;
    private void OnTriggerEnter(Collider hit)
    {
        
        if (hit.CompareTag("Player"))
        {
            canvas1.SetActive(true);
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
