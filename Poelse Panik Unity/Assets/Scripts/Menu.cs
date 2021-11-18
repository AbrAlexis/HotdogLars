using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject MenuPanel;
    GameObject gameManager;
    public Sprite StartGreenSprite;
    public Image StartImg;
    Items itemsRef;
    GameObject timer;
    Timer timerRef;
    public Image NPCFrame;
    public Image GameOver;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        timer = GameObject.Find("Timer");
        timerRef = timer.GetComponent<Timer>();
        itemsRef = gameManager.GetComponent<Items>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame()
    {
        itemsRef.ResetItemsCountPlayer();
        itemsRef.ResetItemsCount();
        itemsRef.ItemsChoosen.Clear();
        timerRef.timeRemaining = 11f;
        itemsRef.Chooseitems(2);
        itemsRef.ChooseNumOfItems();
        MenuPanel.SetActive(false);
    }

    public void ChangePic()
    {
        StartImg.sprite = StartGreenSprite;
    }

    public void BackToMenu()
    {
        MenuPanel.SetActive(true);
    }

    public void HideMenu()
    {
        MenuPanel.SetActive(false);
    }

}
