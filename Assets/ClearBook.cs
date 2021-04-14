using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearBook : MonoBehaviour
{

    public GameObject can1;
    public GameObject can2;
    public GameObject can3;
    public GameObject can4;


    // Start is called before the first frame update
    void Start()
    {
        if(can1.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                can1.SetActive(false);
            }
        }
        if (can2.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                can2.SetActive(false);
            }
        }
        if (can3.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                can3.SetActive(false);
            }
        }
        if (can4.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                can4.SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
