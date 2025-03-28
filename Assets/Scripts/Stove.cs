using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Stove : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ToastedWatermelon;
    public GameObject ToastedEarth;
    public Interact interact;
    public string cookedFood;
    void Start()
    {
        ToastedWatermelon.SetActive(false);
    }

    public void ToastWatermelon()
    {
        //print("Toast Watermelon was called");
        ToastedWatermelon.SetActive(true);
        cookedFood = "ToastedWatermelon";
        print("Toast Watermelon was called");
    }

    public void CleanStove()
    {
        print("FJIAFHAFH");
        interact.heldItem.SetActive(true);
        cookedFood = "";
    }
}
