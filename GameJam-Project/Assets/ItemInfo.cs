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
        description.text = "������ʯ";
    }
    public void item2()
    {
        description.text = "����ͭ��";
    }
    public void item3()
    {
        description.text = "��������";
    }
    public void item4()
    {
        description.text = "���ǽ�";
    }
    public void item5()
    {
        description.text = "������ʯ";
    }
    public void item6()
    {
        description.text = "������ʯ";
    }
    public void item7()
    {
        description.text = "������ʯ";
    }
    public void item8()
    {
        description.text = "������ʯ";
    }
    public void item9()
    {
        description.text = "������ʯ";
    }
    public void item10()
    {
        description.text = "������ʯ";
    }
    public void item11()
    {
        description.text = "������ʯ";
    }
    public void item12()
    {
        description.text = "������ʯ";
    }
    public void item13()
    {
        description.text = "������ʯ";
    }
    public void item14()
    {
        description.text = "������ʯ";
    }

}
