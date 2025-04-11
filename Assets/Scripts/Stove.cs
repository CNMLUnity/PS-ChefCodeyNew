using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Stove : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Game Objects")]
    public GameObject ToastedWatermelon;
    public GameObject ServedWatermelon;
    [Header("String + Script")]
    public Interact interact;
    public string cookedFood;
    [Header("Particle Systems")]
    public ParticleSystem smoke;
    public ParticleSystem complete;
    public bool cook;

    void Start()
    {
        ToastedWatermelon.SetActive(false);
        cook = false;
    }

    public void ToastWatermelon()
    {
        //print("Toast Watermelon was called");
        smoke.Play();
        ToastedWatermelon.SetActive(true);
        cookedFood = "ToastedWatermelon";
        print("Toast Watermelon was called");
        Invoke("CompleteCooking", 5f);
    }

       public void ServeWatermelon()
    {
        //print("Toast Watermelon was called");
        ServedWatermelon.SetActive(true);
        print("Toast Watermelon was called");
    }

    public void CleanStove()
    {
        print("FJIAFHAFH");
        interact.heldItem.SetActive(true);
        cookedFood = "";
        complete.Stop();
    }

    public void CompleteCooking()
    {
        smoke.Stop();
        complete.Play();
        cook = true;
    }
}
