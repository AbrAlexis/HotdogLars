using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextControllerPlayer : TextController
{
    Items itemsRef;
    Dictionary<string, int> itemsDictPlayer = new Dictionary<string, int>();
    GameObject GameManager;

    // Start is called before the first frame update
    void Start()
    {
        GameManager = GameObject.Find("GameManager");
        itemsRef = GameManager.GetComponent<Items>();
        itemsDictPlayer = itemsRef.PlayerItemsDict;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateItemText(textItem, itemsDictPlayer, itemTextRef);
    }
}
