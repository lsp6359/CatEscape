using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject gHPgauge = null;
    GameObject gGameOver = null;
    GameObject gRestartBTN = null;
    GameObject arrowGenerator = null;
    PlayerController playerController = null;
   
    //GameObject playerController = null;

    // Start is called before the first frame update
    void Start()
    {
        this.gHPgauge = GameObject.Find("hpGauge");
        this.gGameOver = GameObject.Find("GameOver");
        this.gRestartBTN = GameObject.Find("ReButton");
        this.arrowGenerator = GameObject.Find("ArrowGenerator");
        this.playerController = GameObject.Find("player").GetComponent<PlayerController>();
        
        gRestartBTN.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //hp가 0이라면
        if (gHPgauge.GetComponent<Image>().fillAmount == 0)
        {
            //일시정지
            Time.timeScale = 0f;

            //리스타트 버튼 띄우기
            GameOver();
        }
    }

    //체력이 줄게만드는 함수
    public void DecreseHP()
    {
        this.gHPgauge.GetComponent<Image>().fillAmount -= 0.1f;
    }

    //게임 오버, 다시 하시겠습니가?
    public void GameOver()
    {
        gGameOver.SetActive(true);
        gGameOver.GetComponent<Text>().text = "게임 오버!";
        gRestartBTN.SetActive(true);
       
    }
    
    //게임 다시시작, 초기상태로
    public void GameRe()
    {

        // 체력 풀피
        gHPgauge.GetComponent<Image>().fillAmount = 1f;
        
        // 게임오버 메시지 없애기
        gGameOver.SetActive(false);

        // 일시정지 해제
        Time.timeScale = 1f;


        // 화살 다 없애기
        arrowGenerator.GetComponent<ArrowGenerator>().Desto();

        // 고양이 제자리
        playerController.CatPosition();


        // restart버튼 없애기
        gRestartBTN.SetActive(false);

    }
 
}
