using UnityEngine;

public class CameraFollow2D : MonoBehaviour
{
    public Transform target; // 要跟随的目标
    public float smoothTime = 0.5f; // 平滑跟随的时间
    private Vector3 velocity = Vector3.zero; // 相机移动的速度

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("CameraPoint").GetComponent<Transform>();
    }
    void FixedUpdate()
    {
        if (target != null)
        {
            // 计算目标位置
            Vector3 desiredPosition = new Vector3(target.position.x, target.position.y, transform.position.z);
            // 平滑移动相机到目标位置
            transform.position = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothTime);
        }
    }
}