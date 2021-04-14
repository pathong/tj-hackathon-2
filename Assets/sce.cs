using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sce : MonoBehaviour
{
    public GameObject canv;

    // Start is called before the first frame update
    void Start()
    {
        if (canv.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                SceneManager.LoadScene(1);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
