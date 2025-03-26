using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectRandomPowerup : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> powerupList; 
    public int randomNumberInList;
    public GameObject chosenPowerup;
    public bool isPowerupChosen;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ItemBox")
        {
            Debug.Log("1");
            randomNumberInList = Random.Range(0, powerupList.Count);
            chosenPowerup = powerupList[randomNumberInList];
            Debug.Log("2");
            
        }
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown("space") && chosenPowerup)
            {
                print("hi");
                Instantiate(chosenPowerup,new Vector3 (transform.position.x, transform.position.y, transform.position.z + 4), transform.rotation);           
            }
    }
}
