using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Stove : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ToastedWatermelon;
    public GameObject ToastedEarth;
    public GameObject ToastedIceCream;
    public Interact interact;
    public string cookedFood = "";
    void Start()
    {
        ToastedWatermelon.SetActive(false);
        ToastedEarth.SetActive(false);
        ToastedIceCream.SetActive(false);
    }

    public void ToastWatermelon()
    {
        print("Toast Watermelon was called");
        ToastedWatermelon.SetActive(true);
        cookedFood = "ToastedWatermelon";
    }

     public void ToastEarth()
    {
        print("Toast Earth was called");
        ToastedEarth.SetActive(true);
        cookedFood = "Earth";
    }

     public void ToastIceCream()
    {
        print("Toast Earth was called");
        ToastedIceCream.SetActive(true);
        cookedFood = "iceCream";
    }

    public void CleanStove()
    {
        interact.heldItem.SetActive(true);
        cookedFood = "";
    }
}
