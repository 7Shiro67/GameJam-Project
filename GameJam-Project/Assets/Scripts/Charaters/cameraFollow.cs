using UnityEngine;

public class CameraFollow2D : MonoBehaviour
{
    public Transform target; // Ҫ�����Ŀ��
    public float smoothTime = 0.5f; // ƽ�������ʱ��
    private Vector3 velocity = Vector3.zero; // ����ƶ����ٶ�

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("CameraPoint").GetComponent<Transform>();
    }
    void FixedUpdate()
    {
        if (target != null)
        {
            // ����Ŀ��λ��
            Vector3 desiredPosition = new Vector3(target.position.x, target.position.y, transform.position.z);
            // ƽ���ƶ������Ŀ��λ��
            transform.position = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothTime);
        }
    }
}