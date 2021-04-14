using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class game_con: MonoBehaviour
{
    public GameObject dia1;
    public GameObject dia2;
    public GameObject dia3;
    public GameObject dia4;
    public GameObject dia5;
    public GameObject dia6;
    public GameObject dia7;
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
        if (dia1.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                dia2.SetActive(true);
                dia1.SetActive(false);
            }
        }
        else if (dia2.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                dia3.SetActive(true);
                dia2.SetActive(false);
            }
        }
        else if (dia3.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                dia4.SetActive(true);
                dia3.SetActive(false);
            }
        }

        else if (dia4.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                dia5.SetActive(true);
                dia4.SetActive(false);
            }
        }

        else if (dia5.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                dia6.SetActive(true);
                dia5.SetActive(false);
            }
        }

        else if (dia6.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                dia7.SetActive(true);
                dia6.SetActive(false);
            }
        }

        else if (dia7.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                dia7.SetActive(false);
            }
           
        }
    }

}