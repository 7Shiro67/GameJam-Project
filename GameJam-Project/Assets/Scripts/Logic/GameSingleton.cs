using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSingleton : MonoBehaviour
{
    public static GameSingleton Instance { get; private set; }
    public GameObject player;

    void Awake()
    {
        // 检查是否已经存在实例
        if (Instance == null)
        {
            // 如果不存在，将当前实例赋值给静态变量
            Instance = this;
            DontDestroyOnLoad(gameObject); // 防止切换场景时销毁
        }
        else if (Instance != this)
        {
            // 如果已存在实例，销毁当前对象
            Destroy(gameObject);
        }
    }
}

