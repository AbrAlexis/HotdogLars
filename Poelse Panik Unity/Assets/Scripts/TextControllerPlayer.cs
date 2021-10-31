using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextControllerPlayer : TextController
{
    Items items_Ref;
    Dictionary<string, int> itemsDictPlayer_ = new Dictionary<string, int>();
    GameObject GameManager;

    // Start is called before the first frame update
    void Start()
    {
        GameManager = GameObject.Find("GameManager");
        items_Ref = GameManager.GetComponent<Items>();
        itemsDictPlayer_ = items_Ref.PlayerItemsDict;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateItemText(textItem, itemsDictPlayer_, itemTextRef);
    }
}
