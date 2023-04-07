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
        //hp�� 0�̶��
        if (gHPgauge.GetComponent<Image>().fillAmount == 0)
        {
            //�Ͻ�����
            Time.timeScale = 0f;

            //����ŸƮ ��ư ����
            GameOver();
        }
    }

    //ü���� �ٰԸ���� �Լ�
    public void DecreseHP()
    {
        this.gHPgauge.GetComponent<Image>().fillAmount -= 0.1f;
    }

    //���� ����, �ٽ� �Ͻðڽ��ϰ�?
    public void GameOver()
    {
        gGameOver.SetActive(true);
        gGameOver.GetComponent<Text>().text = "���� ����!";
        gRestartBTN.SetActive(true);
       
    }
    
    //���� �ٽý���, �ʱ���·�
    public void GameRe()
    {

        // ü�� Ǯ��
        gHPgauge.GetComponent<Image>().fillAmount = 1f;
        
        // ���ӿ��� �޽��� ���ֱ�
        gGameOver.SetActive(false);

        // �Ͻ����� ����
        Time.timeScale = 1f;


        // ȭ�� �� ���ֱ�
        arrowGenerator.GetComponent<ArrowGenerator>().Desto();

        // ����� ���ڸ�
        playerController.CatPosition();


        // restart��ư ���ֱ�
        gRestartBTN.SetActive(false);

    }
 
}
