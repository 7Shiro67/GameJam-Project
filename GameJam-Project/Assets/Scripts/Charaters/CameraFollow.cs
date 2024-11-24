using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
   public Transform target; // ����������Ŀ��
    public float smoothSpeed = 0.5f; // ƽ���ٶ�

    void LateUpdate()
    {
        // ����Ŀ��λ�ú͵�ǰλ��֮��Ĳ���
        Vector3 desiredPosition = new Vector3(target.position.x, target.position.y, transform.position.z);
        // ʹ��Lerp����ƽ���ƶ�
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;
    }
}
