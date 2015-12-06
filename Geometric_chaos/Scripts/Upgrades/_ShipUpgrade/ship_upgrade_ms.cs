using UnityEngine;
using System.Collections;

public class ship_upgrade_ms : MonoBehaviour {


    
    public GameObject fill_bar;    					//bara care se umple
    public TextMesh show_price;    					//textul care arata pretul
    public float current_fill_level = 0f;	   	//este folosit pentru bara de fill supra 10
    public int price = 10;								//pretul
    public static int ship_ms_upgrade;				///in functie de asta se upgradeaza nava
    
    
    
    
   
    
    void Update()
    {
        Price_Text();
        Scale_Fill_Bar();
    }
    
    void OnMouseDown()
    {
        if (current_fill_level < 1.0f)
        {
            if (coinsGathered.coins >= price)
            {
                coinsGathered.coins -= price;
                price += ship_ms_upgrade + price + 10 ;
                current_fill_level += 0.1f;

                fill_bar.GetComponent<SpriteRenderer>().color -= new Color(0.05f, 0.1f, 0.1f, 0f);

                ship_ms_upgrade++;
            }
        }
    }
    
    void Price_Text()
    {
        show_price.text = price.ToString("N0") + " Gc"; 
    }
    
    void Scale_Fill_Bar()
    {
        fill_bar.transform.localScale = new Vector3(current_fill_level, 1f, 1f);
    }

    
}
