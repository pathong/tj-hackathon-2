using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class game_con_2 : MonoBehaviour
{
    public GameObject dial1;
    public GameObject dial2;
    public GameObject dial3;
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
        if (dial1.activeSelf == true)
        {
            if(Input.GetKeyDown(KeyCode.Backspace))
            {
                dial2.SetActive(true);
                dial1.SetActive(false);
            }
        }

        else if (dial2.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                dial3.SetActive(true);
                dial2.SetActive(false);
            }
        }

        else if (dial3.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                dial3.SetActive(false);
            }
        }
    }
}
