using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    // Start is called before the first frame update
    public string triggerName = "";
    public GameObject Watermelon;
    public GameObject heldItem;
    public string heldItemName;
    public Stove stove;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            //print(triggerName);

            if (triggerName == "Watermelon_512")
            {
                print("Space - Codey must pick up the Watermelon.");
                heldItem = Instantiate(Watermelon, transform, false);
                heldItem.transform.localScale = new Vector3(1, 1, 1);
                heldItem.transform.position =  gameObject.transform.position + new Vector3(0, 10, 2);
                heldItemName = "Watermelon";
            }

            if(triggerName == "Stove")
            {
                print("Codey is at the stove and will be incinerated.");
                    
                if(heldItemName == "Watermelon")
                {
                    print("Ready to toast.");
                    stove.ToastWatermelon();
                    Destroy(heldItem);
                }else{
                    if(stove.cookedFood == "ToastedWatermelon")
                    {
                        stove.ToastedWatermelon.SetActive(false);
                        Watermelon.SetActive(true);
                        heldItem = Instantiate(Watermelon, transform, false);
                        heldItem.transform.localScale = new Vector3(1, 1, 1);
                        heldItem.transform.localPosition=  gameObject.transform.position + new Vector3(0, 10, 2);
                        heldItemName = "melonSlice";
                        stove.CleanStove();
                    }
                }
            }
        } 
    }

    void OnTriggerEnter(Collider other)
    {
        triggerName = other.gameObject.name;
        print(triggerName);
    }
        
    void OnTriggerExit(Collider other)
    {
        triggerName = "";
    }
}

    
    

