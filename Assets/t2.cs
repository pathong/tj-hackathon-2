using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t2 : MonoBehaviour
{

    public GameObject new2;

    private void OnTriggerEnter(Collider hit)
    {
        if (hit.CompareTag("Player"))
        {
            new2.SetActive(true);
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
            }
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                Time.timeScale = 1;
                new2.SetActive(false);
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
