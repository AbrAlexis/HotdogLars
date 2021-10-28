using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    GameObject gameManager;
    NPCBestilling npcBestillingRef;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        npcBestillingRef = gameManager.GetComponent<NPCBestilling>();
        npcBestillingRef.OrdrerGenerering(11);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
