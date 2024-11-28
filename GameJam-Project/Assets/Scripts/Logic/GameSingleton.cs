using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSingleton : MonoBehaviour
{
    public static GameSingleton Instance { get; private set; }
    public GameObject player;

    void Awake()
    {
        // ����Ƿ��Ѿ�����ʵ��
        if (Instance == null)
        {
            // ��������ڣ�����ǰʵ����ֵ����̬����
            Instance = this;
            DontDestroyOnLoad(gameObject); // ��ֹ�л�����ʱ����
        }
        else if (Instance != this)
        {
            // ����Ѵ���ʵ�������ٵ�ǰ����
            Destroy(gameObject);
        }
    }
}

