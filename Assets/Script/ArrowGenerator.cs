using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject gArrowPrefab = null;
    float fSpan = 0.1f;
    float fDelta = 0;

    // 화살 생성하기 위한 빈 상자
    GameObject arrow = null;

    // 배열 생성하기 위한 코드
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

            //arrow 변수에 프리팹 인스턴트
            arrow = Instantiate(gArrowPrefab);
            
            // 랜덤한 수 뽑기(-12 ~ 12까지)
            int px = Random.Range(-12, 13);

            // 뽑힌 숫자대로 좌표에 화살 생성
            arrow.transform.position = new Vector3(px, 7, 0);


            // arrows 배열에 화살 추가
            arrows.Add(arrow);
        }

    }
    
    public  void Desto()
    {

        foreach (GameObject Destroy_arrow in arrows)
        {
            Destroy(Destroy_arrow);
        }
        arrows.Clear(); // 리스트 초기화

    }
   

}
