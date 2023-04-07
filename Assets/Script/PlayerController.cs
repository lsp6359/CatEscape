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

    // ����� ������
    public void CatMove()
    {
        //ĳ���Ͱ� �̵��� ������ x��ǥ -11.5 ~ 11.5���� �̴�.
        range = Mathf.Clamp(range, -11.5f, 11.5f);

        //������ �������� ���� �����̰�
        if (Time.timeScale == 1)
        {
            // ���� ȭ��ǥ�� ������ ��
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                range -= 0.8f;
            }

            // ������ ȭ��ǥ�� ������ ��
            if (Input.GetKey(KeyCode.RightArrow))
            {
                range += 0.8f;
            }
        }
       
        // ĳ���� �̵�
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

    //����� ó����ġ
    public void CatPosition()
    {
        range = 0;
        
    }
}
