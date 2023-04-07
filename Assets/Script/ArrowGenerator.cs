using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject gArrowPrefab = null;
    float fSpan = 0.1f;
    float fDelta = 0;

    // ȭ�� �����ϱ� ���� �� ����
    GameObject arrow = null;

    // �迭 �����ϱ� ���� �ڵ�
    List<GameObject> arrows = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.fDelta += Time.deltaTime;
        if(fDelta > this.fSpan)
        {
            this.fDelta = 0;

            //arrow ������ ������ �ν���Ʈ
            arrow = Instantiate(gArrowPrefab);
            
            // ������ �� �̱�(-12 ~ 12����)
            int px = Random.Range(-12, 13);

            // ���� ���ڴ�� ��ǥ�� ȭ�� ����
            arrow.transform.position = new Vector3(px, 7, 0);


            // arrows �迭�� ȭ�� �߰�
            arrows.Add(arrow);
        }

    }
    
    public  void Desto()
    {

        foreach (GameObject Destroy_arrow in arrows)
        {
            Destroy(Destroy_arrow);
        }
        arrows.Clear(); // ����Ʈ �ʱ�ȭ

    }
   

}
