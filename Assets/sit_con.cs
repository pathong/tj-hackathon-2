using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sit_con : MonoBehaviour
{
    public GameObject si1;
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
        if(si1.activeSelf == true)
        {
            if(Input.GetKeyDown(KeyCode.Backspace))
            {
                si1.SetActive(false);
            }
        }
    }
}
