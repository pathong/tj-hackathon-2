using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b1 : MonoBehaviour
{
    public GameObject news;
    private void OnTriggerEnter(Collider hit)
    {
        if(hit.CompareTag("Player"))
        {
            news.SetActive(true);

            
        }
        if (news.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                news.SetActive(false);

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
