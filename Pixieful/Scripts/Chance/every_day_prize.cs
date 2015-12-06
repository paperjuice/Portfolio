using UnityEngine;
using System.Collections;
using System;

public class every_day_prize : MonoBehaviour {

    //[SerializeField]
    private int old_day;
    //[SerializeField]
    private int new_day;
    

    public GameObject prize_tab;
    public int multiplier;
    



    void Awake()
    {
       // PlayerPrefs.SetInt("tokkens", tokkens.tokken);

        tokkens.tokken = PlayerPrefs.GetInt("tokkens");


        //save the multiplier
        if (PlayerPrefs.GetInt("multiplier") != 0)
        {
            multiplier = PlayerPrefs.GetInt("multiplier");
        }

        if(PlayerPrefs.GetInt("new_day") == 0)
        {
            old_day = System.DateTime.Now.Day - 1; 
        }

        else if (PlayerPrefs.GetInt("new_day") != null)
        {
            old_day = PlayerPrefs.GetInt("new_day");
        }
    }

    void Start()
    {
        new_day = System.DateTime.Now.Day;
        PlayerPrefs.SetInt("new_day", new_day);

        New_day_prize();
    }

    void New_day_prize()
    {
        //first start ever
        if (new_day - old_day == 1)
        {
            multiplier++;
            PlayerPrefs.SetInt("multiplier", multiplier);
            prize_tab.gameObject.SetActive(true);
        }
        //when skiped one or more days
        if (new_day - old_day > 1)
        {
            multiplier = 1;
            PlayerPrefs.SetInt("multiplier", multiplier);
            prize_tab.gameObject.SetActive(true);
        }
    }
}
