using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class des : MonoBehaviour
{
    private void OnTriggerEnter(Collider hit)
    {
        if (hit.CompareTag("Player2"))
        {
            Destroy(gameObject);

        }
        if (hit.CompareTag("Player"))
        {

            SceneManager.LoadScene(1);
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
