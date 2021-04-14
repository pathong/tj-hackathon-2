using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class game_con_3 : MonoBehaviour
{
    public GameObject di1;
    public GameObject di2;
    public GameObject di3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Check();
    }

    private void Check()
    {
        if(di1.activeSelf == true)
        {
            if(Input.GetKeyDown(KeyCode.Backspace))
            {
                di2.SetActive(true);
                di1.SetActive(false);
            }
        }

        else if (di2.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                di3.SetActive(true);
                di2.SetActive(false);
            }
        }

        else if (di3.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                di3.SetActive(false);
            }
        }
    }
}
