using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    public Image NPCFrame;
    public GameObject buttons;
    public float timeRemaining = 11f;
    GameObject gameManager;
    LevelManager LevelManagerRef;


    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        LevelManagerRef = gameManager.GetComponent<LevelManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (LevelManagerRef.GameOn == true) 
        {
            DisplayTimer();
            HideOrder();
            EnableButtons();
        }
    }

    void DisplayTimer()
    {
        if (timeRemaining > 0)
        {
            int i = (int)timeRemaining;
            timerText.text = i.ToString();
            timeRemaining -= Time.deltaTime;
        }
    }

    void HideOrder()
    {
        if (timeRemaining <= 0 && NPCFrame.enabled != false)
        {
            NPCFrame.gameObject.SetActive(false);
        }
    }

    void EnableButtons()
    {
        if (timeRemaining <= 0 && buttons.activeSelf != true)
        {
            buttons.gameObject.SetActive(true);
        }
    }
    public void DisableButtons()
    {
        buttons.gameObject.SetActive(false);
    } 

    public void Skip()
    {
        timeRemaining = 0f;
        timerText.text = "0";
    }
}