using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    Rigidbody rig;
    public float speed = 8.0f;
    public float jumpPower = 3.0f;
    public bool isGrounded = false;
    public int jumpCount = 2;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        jumpCount = 0;

    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ground")
        {

            isGrounded = true;    //Ground에 닿으면 isGround는 true
            jumpCount = 2;          //Ground에 닿으면 점프횟수가 2로 초기화됨

        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, transform.position.z );
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, transform.position.z);
        }
        if (isGrounded)
        {
            if (jumpCount > 0)
            {
                if (Input.GetKeyDown(KeyCode.UpArrow))   //입력키가 위화살표면 실행함
                {
                    rig.AddForce(new Vector3(0, 1, 0) * jumpPower, ForceMode.Impulse); //위방향으로 올라가게함
                    jumpCount--;    //점프할때 마다 점프횟수 감소
                }
            }
        }
    }
}
