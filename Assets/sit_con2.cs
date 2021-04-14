using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sit_con2 : MonoBehaviour
{
    public GameObject sit1;
    public GameObject sit2;
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
        if(sit1.activeSelf == true)
        {
            if(Input.GetKeyDown(KeyCode.Backspace))
            {
                sit1.SetActive(false);
                sit2.SetActive(true);
            }
        }

        else if (sit2.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                sit2.SetActive(false);
            }
        }
    }
}
