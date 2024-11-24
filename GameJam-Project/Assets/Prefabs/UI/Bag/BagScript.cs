using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagScript : MonoBehaviour
{
    public GameObject Bag;
    public bool isOpen = false;
    void Update()
    {
        bagState();
    }
    public void bagState()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            isOpen = !isOpen;
            Bag.SetActive(isOpen);
        }
        
    }
}
