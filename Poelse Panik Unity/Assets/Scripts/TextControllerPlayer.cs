using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextControllerPlayer : TextController
{
    Items itemsRef;
    Dictionary<string, int> itemsDictPlayer = new Dictionary<string, int>();
    GameObject gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        itemsRef = gameManager.GetComponent<Items>();
    }

    // Update is called once per frame
    void Update()
    {
        itemsDictPlayer = itemsRef.PlayerItemsDict;
        UpdateItemText(textItem, itemsDictPlayer, itemTextRef);
    }
}
