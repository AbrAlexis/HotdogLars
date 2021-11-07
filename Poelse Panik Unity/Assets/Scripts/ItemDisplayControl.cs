using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDisplayControl : MonoBehaviour
{
    public Image itemImage;
    public string itemString;
    Dictionary<string, int> itemsDict = new Dictionary<string, int>();
    Items itemsRef;
    GameObject gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        itemsRef = gameManager.GetComponent<Items>();
        itemsDict = itemsRef.ItemsDict;
    }

    // Update is called once per frame
    void Update()
    {
        DisplayItem(itemString, itemImage, itemsDict);
    }

    public void DisplayItem(string itemString, Image itemImg, Dictionary<string, int> Dict)
    {
        if (Dict[itemString] == 0)
        {
            itemImg.gameObject.SetActive(false);
        }

        else
        {
            itemImg.gameObject.SetActive(true);
        }
    }
}
