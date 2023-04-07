using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    GameObject gDirector = null;
    GameObject gPlayer = null;
    Vector2 vPosition1 = Vector2.zero;
    Vector2 vPosition2 = Vector2.zero;
    Vector2 vDistance = Vector2.zero;
   

    // Start is called before the first frame update
    void Start()
    {
        this.gDirector = GameObject.Find("GameDirector");
        this.gPlayer = GameObject.Find("player");
        
    }

    // Update is called once per frame
    void Update()
    {
        
        // 게임이 진행중인 상태라면 화살 쏟아짐
        if (Time.timeScale == 1)
        {
            // 프레임마다 등속으로 낙하시킨다.
            transform.Translate(0, -0.1f, 0);
        }

        // 화면 밖으로 나오면 오브젝트를 소멸시킨다.
        if (transform.position.y < -5.0f)
        {
          
            ArrowDestroy();
        }

      

        // 충돌 판정
        vPosition1 = transform.position;               // 화살의 중심 좌표
        vPosition2 = this.gPlayer.transform.position;  // 플레이어의 중심 좌표
        vDistance = vPosition1 - vPosition2;
        float fDistance = vDistance.magnitude;
        float fR1 = 0.5f;                               // 화살의 반경
        float fR2 = 1.0f;                               // 플레이어의 반경

        if (fDistance < fR1 + fR2)
        {
            gDirector.GetComponent<GameDirector>().DecreseHP();

            // 충돌한 경우는 화살을 지운다.
            ArrowDestroy();
        }


      

    }

    // 화살 없애는 함수
    public void ArrowDestroy()
    {
        Destroy(gameObject);
    }
  
}
