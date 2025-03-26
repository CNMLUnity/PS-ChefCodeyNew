using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    // Start is called before the first frame update
    public string triggerName = "";
    public GameObject fries;
    public GameObject Watermelon;
    public GameObject cake;
    public GameObject Hamburger;
    public GameObject IceCream;
    public GameObject skull;
    public GameObject Earth;
    public GameObject heldItem;
    public GameObject ToastedWatermelonObj;
    public GameObject ToastedIceCream;
    public GameObject ToastedEarth;
    public string heldItemName;
    public Stove stove;

    private IEnumerator coroutine; // resest active after time
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

            

            if (triggerName == "IceCream")
            {
                print("Space -  Codey must pick up the Ice Cream.");
                heldItem = Instantiate(IceCream, transform, false);
                heldItem.transform.localScale = new Vector3(10, 10, 10);
                heldItem.transform.position =  gameObject.transform.position + new Vector3(0, 10, 2);
                heldItemName = "iceCream";
            }
            
            if (triggerName == "Earth")
            {
                print("Space - Codey must pick up the Earth.");
                heldItem = Instantiate(Earth, transform, false);
                heldItem.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                heldItem.transform.position = new Vector3(5, 2, 2);
                heldItem.transform.position =  gameObject.transform.position + new Vector3(0, 10, 2);
                heldItemName = "Earth";
            }

            if(triggerName == "Stove")
            {
                print("Codey is at the stove and will be incinerated.");
                    
                if(heldItemName == "Watermelon")
                {
                    print("Ready to toast.");
                    stove.ToastWatermelon();
                    Destroy(heldItem);
                    heldItemName = "";
                } else {
                    print("hi");
                    if(stove.cookedFood == "ToastedWatermelon")
                    { 
                        heldItem = Instantiate(ToastedWatermelonObj, transform, false);
                        print(heldItem.name);
                        heldItem.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                        heldItem.transform.position = new Vector3(5, 2, 2);
                        heldItem.transform.position =  gameObject.transform.position + new Vector3(0, 10, 2);
                        heldItemName = "toastedWatermelon";
                        stove.CleanStove(); 
                    }  
                }

                /*
                 if(heldItemName == "iceCream")
                {
                    print("Ready to toast.");
                    stove.ToastIceCream();
                    Destroy(heldItem);
                }
                else if(heldItemName == "Earth")
                {
                    print("Ready to toast.");
                    stove.ToastEarth();
                    Destroy(heldItem);  
                }
                else
                {
                    

                     if(stove.cookedFood == "Earth")
                    {
                        Earth.SetActive(false);                         
                        heldItem = Instantiate(ToastedEarth, transform, false);
                        heldItem.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                        heldItem.transform.position = new Vector3(5, 2, 2);
                        heldItem.transform.position =  gameObject.transform.position + new Vector3(0, 10, 2);
                        heldItemName = "earthSlice";
                        stove.CleanStove();
                        Invoke("Earth", 5.0f);
                    }
                     if(stove.cookedFood == "IceCream")
                    {
                        IceCream.SetActive(false);
                        heldItem = Instantiate(ToastedIceCream, transform, false);
                        heldItem.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                        heldItem.transform.position = new Vector3(5, 2, 2);
                        heldItem.transform.position =  gameObject.transform.position + new Vector3(0, 10, 2);
                        heldItemName = "iceSlice";
                        stove.CleanStove();
                        Invoke("IceCream", 5.0f);
                    }

                }
                    */
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

    private IEnumerator resetObj(GameObject item, float waitTime){
        yield return new WaitForSeconds(waitTime);
        item.SetActive(true);
    }
}

    
    

