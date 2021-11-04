using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextController : MonoBehaviour
{
    public Text itemTextRef;
    public string textItem;
    Items itemsRef;
    Dictionary <string, int> itemsDict = new Dictionary<string, int>();

    // Start is called before the first frame update
    void Start()
    {
        GameObject gameManager;
        gameManager = GameObject.Find("GameManager");
        itemsRef = gameManager.GetComponent<Items>();
        itemsDict = itemsRef.ItemsDict;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateItemText(textItem, itemsDict, itemTextRef);
    }

    public void UpdateItemText(string textItem, Dictionary<string, int> Dict, Text itemTextRef)
    {
        itemTextRef.text = Dict[textItem].ToString() + "x";
    }

}
