using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerOrdrer : MonoBehaviour {


    public Text ordreText;
    void Start()
    {
        
    }

    public void DisplayOrdrer()
    {
        string ordrerStreng = "";
        ordrer.Sort();
         for (int i = 0; i < ordrer.Count; i++){

            ordrerStreng = ordrerStreng + ordrer[i] + " ";
        }
        ordreText.text = ordrerStreng;
    }
    void Update()
    {
        
        Object.Destroy(gameObject.GetComponent("Fritter"));
    }
   
 

public List<string> ordrer = new List<string>();

    public void TilføjIngrediens(string a) {
        ordrer.Add(a);
        DisplayOrdrer();

    }

    public void SletIngrediens(string a)
    {
        ordrer.Remove(a);
        DisplayOrdrer();
    }


}
