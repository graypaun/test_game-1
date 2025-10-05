using Unity.VisualScripting;
using UnityEngine;

// 플레이어 이동
public class NewMonoBehaviourScript : MonoBehaviour
{
    // 백터 x,y값을 조정할수있는데 백터2 함수를 선언
    public Vector2 InputVec;

    public float speed;

    // 물리바디 2D를 선언
    Rigidbody2D rb;
    
    void Awake()
    {
        //변수 rb에 물리바디2D대입
        rb = GetComponent<Rigidbody2D>();

    }

    
    void Update()
    {
        //백터2함수값을 호라이즌과 버티컬을 대입
        InputVec.x = Input.GetAxisRaw("Horizontal");
        InputVec.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        Vector2 nextVec = InputVec.normalized * speed * Time.deltaTime;
        //위치 이동
        rb.MovePosition(rb.position+ nextVec);
    }
}
