using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDisplayControlPlayer : ItemDisplayControl
{

    Dictionary<string, int> itemsDictPlayer = new Dictionary<string, int>();
    GameObject gameManager;
    BestillingsTjekker bestillingsTjekkerRef;
    LevelManager levelManagerRef;

    public Sprite itemImgCorret;
    public Sprite itemImgWrong;
    public Image itemImageReal;
    public Sprite normalSprite;

    Items itemsRef;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        itemsRef = gameManager.GetComponent<Items>();
        itemsDictPlayer = itemsRef.PlayerItemsDict;
        bestillingsTjekkerRef = gameManager.GetComponent<BestillingsTjekker>();
        levelManagerRef = gameManager.GetComponent<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        DisplayItem(itemString, itemImage, itemsDictPlayer);

        if (levelManagerRef.evaluating == true)
        {
            ShowRightAndWrong(itemString, itemImageReal, itemImgCorret, itemImgWrong);
        }

        else
        {
            ResetImage();
        }
    }

    public void ShowRightAndWrong(string itemString, Image itemImageReal, Sprite itemImgCorret, Sprite itemImgWrong)
    {
        if (bestillingsTjekkerRef.Ens.Contains(itemString))
        {
            itemImageReal.sprite = itemImgCorret;
        }

        else if (bestillingsTjekkerRef.IkkeEns.Contains(itemString))
        {
            itemImageReal.sprite = itemImgWrong;
        }

    }

    public void ResetImage()
    {
        itemImageReal.sprite = normalSprite;
    }
}