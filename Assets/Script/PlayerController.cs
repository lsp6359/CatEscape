using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float range = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        CatMove();

    }

    // 고양이 움직임
    public void CatMove()
    {
        //캐릭터가 이동할 범위는 x좌표 -11.5 ~ 11.5까지 이다.
        range = Mathf.Clamp(range, -11.5f, 11.5f);

        //게임이 진행중일 때만 움직이게
        if (Time.timeScale == 1)
        {
            // 왼쪽 화살표가 눌렸을 때
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                range -= 0.8f;
            }

            // 오른쪽 화살표가 눌렸을 때
            if (Input.GetKey(KeyCode.RightArrow))
            {
                range += 0.8f;
            }
        }
       
        // 캐릭터 이동
        transform.position = new Vector2(range, transform.position.y);
    }

    public void LButtonDown()
    {
        //range = Mathf.Clamp(range, -11.5f, 11.5f);
        range -= 3;
        transform.Translate(range, 0, 0);
    }

    public void RButtonDown()
    {
        //range = Mathf.Clamp(range, -11.5f, 11.5f);
        range += 3;
        transform.Translate(range, 0, 0);
     
    }

    //고양이 처음위치
    public void CatPosition()
    {
        range = 0;
        
    }
}
