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
