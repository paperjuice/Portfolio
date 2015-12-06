using UnityEngine;
using System.Collections;

public class unlock_map : MonoBehaviour {

    

    public TextMesh text;
    public int is_bought = 0;
    public string map_name;
    public float map_price;


    void Start()
    {
        is_bought = PlayerPrefs.GetInt(map_name);
    }

    void Update()
    {
        if (is_bought == 0)
        {
            text.text = "Buy for\n " + map_price.ToString("N0") + "$$";
        }
        else if(is_bought == 1)
        {
            text.text = "Play game!";
        }


        //activate color change on hoover over
        if (map_price <= money.money_amount)
        {
            GetComponent<change_color_on_hover_over>().is_working = true;
        }
        else if (map_price > money.money_amount)
        {
            GetComponent<change_color_on_hover_over>().is_working = false;
        }
    }



    void OnMouseDown()
    {
        if (is_bought == 0)
        {

            //check if you have the money
            if (map_price <= money.money_amount)
            {
                money.money_amount -= map_price;
                is_bought = 1;
                

                //save the bought item
                PlayerPrefs.SetInt(map_name, is_bought);

                //save the money
                PlayerPrefs.SetFloat("money", money.money_amount);
            }
        }
        else if (is_bought == 1)
        {
            Application.LoadLevel(map_name);
        }
    }
    

}
