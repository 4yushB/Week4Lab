using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    int i = 0;
    int j = 0;
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        j = Random.Range(200, 251);
    }

    // Update is called once per frame
    void Update()
    {
        
        Debug.Log(gameObject.name + ": " + i++);

        if (gameObject.tag == "Red" && i == 100)
        {
            gameObject.SetActive(false);
            
        }

        if (gameObject.tag == "Blue" && i == j)
        {
            rend.enabled = false;
           
            
        }
    }
}
