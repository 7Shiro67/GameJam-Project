using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiLogic : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject playerPosition;
    public Text LocationName;

    // Update is called once per frame
    void Update()
    {
        LocationCheck();
    }
    public void LocationCheck()
    {
        if (playerPosition.transform.position.y > -5)
        {
            LocationName.text = "É¯ÃÎµÄ¼Ò";
        }
        else
        {
            LocationName.text = "ÃÎ¾³";
        }
    }
}
