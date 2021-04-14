using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t1 : MonoBehaviour
{

    public GameObject new1;

    private void OnTriggerEnter(Collider hit)
    {
        if (hit.CompareTag("Player"))
        {
            new1.SetActive(true);
            if(Time.timeScale == 1)
            {
                Time.timeScale = 0;
            }
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                Time.timeScale = 1;
                new1.SetActive(false);
            }

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
