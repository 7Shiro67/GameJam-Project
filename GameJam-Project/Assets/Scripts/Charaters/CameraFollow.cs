using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
   public Transform target; // 摄像机跟随的目标
    public float smoothSpeed = 0.5f; // 平滑速度

    void LateUpdate()
    {
        // 计算目标位置和当前位置之间的差异
        Vector3 desiredPosition = new Vector3(target.position.x, target.position.y, transform.position.z);
        // 使用Lerp进行平滑移动
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;
    }
}
