using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WinCondition : MonoBehaviour
{
    GameObject gameManager;
    BestillingsTjekker bestillingsTjekkerRef;
    public Text checkOrdreText;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        bestillingsTjekkerRef = gameManager.GetComponent<BestillingsTjekker>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void YouWin()
    {
        if (bestillingsTjekkerRef.BestillingerEns == true)
        {
            checkOrdreText.text = "Ens";

        }

        else if (bestillingsTjekkerRef.BestillingerEns == false)
        {
            checkOrdreText.text = "Ikke ens";
        }

    }

}
