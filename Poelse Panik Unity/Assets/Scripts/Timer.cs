using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    public float timeRemaining = 10f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int i = (int)timeRemaining;
        timerText.text = i.ToString();
        timeRemaining -= Time.deltaTime;
    }
}
