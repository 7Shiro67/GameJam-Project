using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagState : MonoBehaviour
{
    public bool isOpen=false;
    public GameObject bag;
    void Update()
    {
        bagOpen();
    }
    public void bagOpen()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            isOpen = !isOpen;
            bag.SetActive(isOpen);
        }
    }
}
