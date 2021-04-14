using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plate : MonoBehaviour
{
    public GameObject t1;
    public GameObject t2;
    public GameObject t3;
    public GameObject t4;
    public GameObject t5;
    public GameObject can;
    int a = 0;



    private void OnTriggerEnter(Collider hit)
    {


        if (hit.CompareTag("Player"))
        {
            a = a + 1;
            if (a == 1)
            {
                t1.SetActive(true);

            }
            if (a == 2)
            {
                t2.SetActive(true);

            }
            if (a == 3)
            {
                t3.SetActive(true);

            }
            if (a == 4)
            {
                t4.SetActive(true);

            }
            if (a == 5)
            {
                t5.SetActive(true);
                can.SetActive(true);
            }

        }
    }
        // Update is called once per frame
        void Update()
    {
        
    }
}
