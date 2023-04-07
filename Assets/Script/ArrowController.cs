using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    //테스트
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
        
        // ������ �������� ���¶�� ȭ�� �����
        if (Time.timeScale == 1)
        {
            // �����Ӹ��� ������� ���Ͻ�Ų��.
            transform.Translate(0, -0.1f, 0);
        }

        // ȭ�� ������ ������ ������Ʈ�� �Ҹ��Ų��.
        if (transform.position.y < -5.0f)
        {
          
            ArrowDestroy();
        }

      

        // �浹 ����
        vPosition1 = transform.position;               // ȭ���� �߽� ��ǥ
        vPosition2 = this.gPlayer.transform.position;  // �÷��̾��� �߽� ��ǥ
        vDistance = vPosition1 - vPosition2;
        float fDistance = vDistance.magnitude;
        float fR1 = 0.5f;                               // ȭ���� �ݰ�
        float fR2 = 1.0f;                               // �÷��̾��� �ݰ�

        if (fDistance < fR1 + fR2)
        {
            gDirector.GetComponent<GameDirector>().DecreseHP();

            // �浹�� ���� ȭ���� �����.
            ArrowDestroy();
        }


      

    }

    // ȭ�� ���ִ� �Լ�
    public void ArrowDestroy()
    {
        Destroy(gameObject);
    }
  
}
