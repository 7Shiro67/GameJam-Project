using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemInfo : MonoBehaviour
{
    public Text description;
    private void Start()
    {
        description = GameObject.FindGameObjectWithTag("Description").GetComponent<Text>();
    }
    public void item1()
    {
        description.text = "这是钻石";
    }
    public void item2()
    {
        description.text = "这是铜锭";
    }
    public void item3()
    {
        description.text = "这是铁锭";
    }
    public void item4()
    {
        description.text = "这是金锭";
    }
    public void item5()
    {
        description.text = "这是钻石";
    }
    public void item6()
    {
        description.text = "这是钻石";
    }
    public void item7()
    {
        description.text = "这是钻石";
    }
    public void item8()
    {
        description.text = "这是钻石";
    }
    public void item9()
    {
        description.text = "这是钻石";
    }
    public void item10()
    {
        description.text = "这是钻石";
    }
    public void item11()
    {
        description.text = "这是钻石";
    }
    public void item12()
    {
        description.text = "这是钻石";
    }
    public void item13()
    {
        description.text = "这是钻石";
    }
    public void item14()
    {
        description.text = "这是钻石";
    }

}
