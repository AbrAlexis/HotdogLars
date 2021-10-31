using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDisplayControlPlayer : ItemDisplayControl
{

    Dictionary<string, int> itemsDictPlayer = new Dictionary<string, int>();
    Dictionary<string, int> itemsDictPlayerCopy = new Dictionary<string, int>();
    GameObject gameManager;
    Items itemsRef;
    bool firstTime = true;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        itemsRef = gameManager.GetComponent<Items>();
        itemsDictPlayer = itemsRef.PlayerItemsDict;
        MakeClone(itemsDictPlayer, itemsDictPlayerCopy);
    }

    // Update is called once per frame
    void Update()
    {

        if (DetectUpdate(itemsDictPlayerCopy, itemsRef.PlayerItemsDict, firstTime) == true)
        {
            DisplayItem(itemString, itemImage, itemsDictPlayer);
            firstTime = false;
            itemsDictPlayer = itemsRef.PlayerItemsDict;
        }

    }
}
