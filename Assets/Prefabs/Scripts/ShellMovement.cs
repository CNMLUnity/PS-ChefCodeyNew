using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellMovement : MonoBehaviour
{
    // public GameObject Shell;
    // Start is called before the first frame update\
    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * 50;
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
