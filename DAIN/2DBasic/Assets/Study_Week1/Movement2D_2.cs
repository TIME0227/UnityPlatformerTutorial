using UnityEngine;

public class Movement2D_2 : MonoBehaviour
{
    private float moveSpeed = 5.0f; // �̵� �ӵ�
    private Vector3 moveDirection; // �̵� ����

    public void Setup(Vector3 direction)
    {
        moveDirection = direction;
    }

    private void Update()
    {
        // ���ο� ��ġ = ���� ��ġ + (���� * �ӵ�)
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
}