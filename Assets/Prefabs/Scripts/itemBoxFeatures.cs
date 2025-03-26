using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemBoxFeatures : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
            Invoke("itemBoxRespawn", 3);
        }
    }

    void itemBoxRespawn()
    {
        gameObject.SetActive(true);
    }
}

