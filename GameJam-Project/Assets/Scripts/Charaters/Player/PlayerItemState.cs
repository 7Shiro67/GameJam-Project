using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerItemState : MonoBehaviour
{
    // Start is called before the first frame update
    public Text Description;
    public bool diamond;
    public bool copper;

    public void ChooseButton()
    {
        initialize();
        switch (Description.text)
        {
            case "这是钻石":
                diamond = true;break;
            case "这是铜锭":
                copper = true; break;
        }


    }
    public void initialize()
    {
        diamond = false;
        copper = false;

    }
}
