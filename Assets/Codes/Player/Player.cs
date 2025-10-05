using Unity.VisualScripting;
using UnityEngine;

// �÷��̾� �̵�
public class NewMonoBehaviourScript : MonoBehaviour
{
    // ���� x,y���� �����Ҽ��ִµ� ����2 �Լ��� ����
    public Vector2 InputVec;

    public float speed;

    // �����ٵ� 2D�� ����
    Rigidbody2D rb;
    
    void Awake()
    {
        //���� rb�� �����ٵ�2D����
        rb = GetComponent<Rigidbody2D>();

    }

    
    void Update()
    {
        //����2�Լ����� ȣ������� ��Ƽ���� ����
        InputVec.x = Input.GetAxisRaw("Horizontal");
        InputVec.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        Vector2 nextVec = InputVec.normalized * speed * Time.deltaTime;
        //��ġ �̵�
        rb.MovePosition(rb.position+ nextVec);
    }
}
