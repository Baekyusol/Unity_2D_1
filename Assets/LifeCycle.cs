using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        /*
        if (Input.anyKeyDown)
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");
        */
        /*
        if (Input.GetKeyDown(KeyCode.Return))
            Debug.Log("아이템을 구입하였습니다.");

        if (Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("왼쪽으로 이동 중");

        if (Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("오른쪽 이동을 멈추었습니다.");
        */

        /*
        if (Input.anyKeyDown)
            Debug.Log("미사일 발사!");

        if (Input.GetMouseButton(0))
            Debug.Log("미사일 모으는 중...");

        if (Input.GetMouseButtonUp(0))
            Debug.Log("슈퍼 미사일 발사!!");
        */

        /*
        if (Input.GetButtonDown("Jump"))
            Debug.Log("점프!");

        if (Input.GetButton("Jump"))
            Debug.Log("점프 모으는 중...");

        if (Input.GetButtonUp("Jump"))
            Debug.Log("슈퍼 점프!!");
        */

        /*
        if (Input.GetButton("Horizontal"))
        {
            //중간 값
            //Debug.Log("횡 이동 중..." + Input.GetAxis("Horizontal"));
            //끝 값
            Debug.Log("횡 이동 중..." + Input.GetAxisRaw("Horizontal"));
        }

        if (Input.GetButton("Vertical"))
        {
            //중간 값
            //Debug.Log("횡 이동 중..." + Input.GetAxis("Vertical"));
            //끝 값
            Debug.Log("횡 이동 중..." + Input.GetAxisRaw("Vertical"));
        }
        */

        /*
        void Start()
        {
            
        }

        void Update()
        {
            //Vector3 vec = new Vector3(0, 1f, 0); //벡터값
            Vector3 vec = new Vector3(
                //GetAxis(~~)로 하면 천천히 움직임
                Input.GetAxisRaw("Horizontal"),
                Input.GetAxisRaw("Vertical"),
                0);
            transform.Translate(vec);
        }
        */

        // 델타타임
        void Start()
        {

        }

        void Update()
        {
            //Vector3 vec = new Vector3(0, 1f, 0); //벡터값
            Vector3 vec = new Vector3(
                //GetAxis(~~)로 하면 천천히 움직임
                Input.GetAxisRaw("Horizontal") * Time.deltaTime,
                Input.GetAxisRaw("Vertical") * Time.deltaTime,
                0);
            transform.Translate(vec);
        }


    }
    
}
