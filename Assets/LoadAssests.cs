using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssests : MonoBehaviour
{
    public GameObject redObj;
    [SerializeField] private GameObject blueObj;
    // Start is called before the first frame update
    void Start()
    {
             
        Instantiate(redObj, Vector3.right * 2 , Quaternion.identity);
        Instantiate(blueObj, Vector3.left * 2, Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
