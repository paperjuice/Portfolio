using UnityEngine;
using System.Collections;

public class claim_prize : MonoBehaviour {


    //take the atag of the object with multiplier script
    private GameObject every_day_prize;
    //player tag
    private GameObject player;
    //tutorial tag
    private GameObject tutorial;

    public TextMesh prize_text;


    void Awake()
    {
       // print(tokkens.tokken);

        

        if (PlayerPrefs.GetInt("tokkens") != 0)
        {
            tokkens.tokken = PlayerPrefs.GetInt("tokkens");
        }

        

        every_day_prize = GameObject.FindGameObjectWithTag("daily");
        player = GameObject.FindGameObjectWithTag("Player");
        tutorial = GameObject.FindGameObjectWithTag("tutorial");
    }

    void Start()
    {
        Prizes();

        player.GetComponent<position_on_area>().enabled = false;
        tutorial.GetComponent<tutorial>().enabled = false;

    }


    void OnMouseUp()
    {
        gameObject.SetActive(false);
        player.GetComponent<position_on_area>().enabled = true; 
        tutorial.GetComponent<tutorial>().enabled = true;
    }

    void Prizes()
    {   //day 1
        if (every_day_prize.GetComponent<every_day_prize>().multiplier == 1)
        {
            prize_text.text = "+1 tokken to spend in ''Chance''!\nCome tomorrow for better rewards!!";
            
            tokkens.tokken += 1;

            PlayerPrefs.SetInt("tokkens", tokkens.tokken);
        }

        //day 2
        if (every_day_prize.GetComponent<every_day_prize>().multiplier == 2)
        {
            prize_text.text = "2 tokken + 500$$ \nCome tomorrow for better rewards!!";

            tokkens.tokken += 2;
            money.money_amount += 500f;

            PlayerPrefs.SetFloat("money", money.money_amount);
            PlayerPrefs.SetInt("tokkens", tokkens.tokken);
        }

        //day 3
        if (every_day_prize.GetComponent<every_day_prize>().multiplier == 3)
        {
            prize_text.text = "+3 tokkens!\nCome tomorrow for better rewards!!";
            tokkens.tokken += 3;
            PlayerPrefs.SetInt("tokkens", tokkens.tokken);
        }

        //day 4
        if (every_day_prize.GetComponent<every_day_prize>().multiplier == 4)
        {
            prize_text.text = "4 tokkens + 1000$$\nCome tomorrow for better rewards!!";

            money.money_amount += 1000f;
            tokkens.tokken += 4;

            PlayerPrefs.SetFloat("money", money.money_amount);
            PlayerPrefs.SetInt("tokkens", tokkens.tokken);
        }

        //day 5
        if (every_day_prize.GetComponent<every_day_prize>().multiplier == 5)
        {
            prize_text.text = "+5 tokkens!\nCome tomorrow for better rewards!!";
            tokkens.tokken += 5;
            PlayerPrefs.SetInt("tokkens", tokkens.tokken);
        }

        //day 6
        if (every_day_prize.GetComponent<every_day_prize>().multiplier == 6)
        {
            prize_text.text = "6 tokkens + 2.000$$\nCome tomorrow for better rewards!!";

            money.money_amount += 2000f;
            tokkens.tokken += 6;

            PlayerPrefs.SetFloat("money", money.money_amount);
        }

        //day 7
        if (every_day_prize.GetComponent<every_day_prize>().multiplier >= 7)
        {
            prize_text.text = "+7 tokkens and +2.500$$!";

            tokkens.tokken += 7;
            money.money_amount += 2500f;

            PlayerPrefs.SetInt("tokkens", tokkens.tokken);
            PlayerPrefs.SetFloat("money", money.money_amount);
        }
    }
}
