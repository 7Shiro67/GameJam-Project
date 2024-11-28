using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPointSingleton : MonoBehaviour
{
    // Start is called before the first frame update
    public static TeleportPointSingleton Instance { get; private set; }
    public GameObject targetPosition2;

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
