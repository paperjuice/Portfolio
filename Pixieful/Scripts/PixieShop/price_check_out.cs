using UnityEngine;
using System.Collections;

public class price_check_out : MonoBehaviour {


    public TextMesh text_price;
    public TextMesh text_title;

    public int pixie_code_to_checkout =1;



    //pixie_white_1;
    public int bought_1;
    public float price_1;
    public string title_1;

    //pixie_blue_2;
    public int bought_2;
    public float price_2;
    public string title_2;

    //pixie_green_3;
    public int bought_3;
    public float price_3;
    public string title_3;

    //pixie_purple_4;
    public int bought_4;
    public float price_4;
    public string title_4;

    //pixie_red_5;
    public int bought_5;
    public float price_5;
    public string title_5;

    //pixie_target_6;
    public int bought_6;
    public float price_6;
    public string title_6;

    //pixie_red_glow_7
    public int bought_7;
    public float price_7;
    public string title_7;


    //pixie_yang_8
    public int bought_8;
    public float price_8;
    public string title_8;

    void Awake()
    {
        bought_2 = PlayerPrefs.GetInt("blue_2");
        bought_3 = PlayerPrefs.GetInt("green_3");
        bought_4 = PlayerPrefs.GetInt("purple_4");
        bought_5 = PlayerPrefs.GetInt("red_5");
        bought_6 = PlayerPrefs.GetInt("target_6");
        bought_7 = PlayerPrefs.GetInt("red_glow_7");
        bought_8 = PlayerPrefs.GetInt("yang_8");
    }

    void Update()
    {
        Pixie_white_1();
        Pixie_blue_2();
        Pixie_green_3();
        Pixie_purple_4();
        Pixie_red_5();
        Pixie_target_6();
        Pixie_red_glow_7();
        Pixie_yang_8();
    }

    void OnMouseDown()
    {
        //pixie_white - 1
        if (pixie_code_to_checkout == 1)
        {
            if (bought_1 == 0)
            {
                if (money.money_amount >= price_1)
                {
                    money.money_amount -= price_1;
                    bought_1 = 1;
                    ins_bought_item.pixie_code_check = 1;

                    //save the money
                    PlayerPrefs.SetFloat("money", money.money_amount);

                    //save the pixie
                    PlayerPrefs.SetInt("white_1", bought_1);
                }
            }
            else if (bought_1 == 1)
            {
                ins_bought_item.pixie_code_check = 1;
            }
        }

        //pixie_blue  - 2
        if (pixie_code_to_checkout == 2)
        {
            if (bought_2 == 0)
            {
                if (money.money_amount >= price_2)
                {
                    money.money_amount -= price_2;
                    bought_2 = 1;
                    ins_bought_item.pixie_code_check = 2;

                    //save the money
                    PlayerPrefs.SetFloat("money", money.money_amount);

                    //save the pixie
                    PlayerPrefs.SetInt("blue_2", bought_2);
                }
            }
            else if (bought_2 == 1)
            {
                ins_bought_item.pixie_code_check = 2;
            }
        }

        //pixie_green - 3
        if (pixie_code_to_checkout == 3)
        {
            if (bought_3 == 0)
            {
                if (money.money_amount >= price_3)
                {
                    money.money_amount -= price_3;
                    bought_3 = 1;
                    ins_bought_item.pixie_code_check = 3;

                    //save the money
                    PlayerPrefs.SetFloat("money", money.money_amount);

                    //save the pixie
                    PlayerPrefs.SetInt("green_3", bought_3);
                }
            }
            else if (bought_3 == 1)
            {
                ins_bought_item.pixie_code_check = 3;
            }
        }

        //pixie_purple - 4
        if (pixie_code_to_checkout == 4)
        {
            if (bought_3 == 0)
            {
                if (money.money_amount >= price_4)
                {
                    money.money_amount -= price_4;
                    bought_4 = 1;
                    ins_bought_item.pixie_code_check = 4;

                    //save the money
                    PlayerPrefs.SetFloat("money", money.money_amount);

                    //save the pixie
                    PlayerPrefs.SetInt("purple_4", bought_4);
                }
            }
            else if (bought_4 == 1)
            {
                ins_bought_item.pixie_code_check = 4;
            }
        }

        //pixie_red - 5
        if (pixie_code_to_checkout == 5)
        {
            if (bought_5 == 0)
            {
                if (money.money_amount >= price_5)
                {
                    money.money_amount -= price_5;
                    bought_5 = 1;
                    ins_bought_item.pixie_code_check = 5;

                    //save the money
                    PlayerPrefs.SetFloat("money", money.money_amount);

                    //save the pixie
                    PlayerPrefs.SetInt("red_5", bought_5);
                }
            }
            else if (bought_5 == 1)
            {
                ins_bought_item.pixie_code_check = 5;
            }
        }

        //pixie_target -6
        if (pixie_code_to_checkout == 6)
        {
            if (bought_6 == 0)
            {
                if (money.money_amount >= price_6)
                {
                    money.money_amount -= price_6;
                    bought_6 = 1;
                    ins_bought_item.pixie_code_check = 6;

                    //save the money
                    PlayerPrefs.SetFloat("money", money.money_amount);

                    //save the pixie
                    PlayerPrefs.SetInt("target_6", bought_6);

                }
            }
            else if (bought_6 == 1)
            {
                ins_bought_item.pixie_code_check = 6;
            }
        }

        //pixie_red_glow - 7
        if (pixie_code_to_checkout == 7)
        {
            if (bought_7 == 0)
            {
                if (money.money_amount >= price_7)
                {
                    money.money_amount -= price_7;
                    bought_7 = 1;
                    ins_bought_item.pixie_code_check = 7;

                    //save the money
                    PlayerPrefs.SetFloat("money", money.money_amount);

                    //save the pixie
                    PlayerPrefs.SetInt("red_glow_7", bought_7);
                }
            }
            else if (bought_7 == 1)
            {
                ins_bought_item.pixie_code_check = 7;
            }
        }

        //pixie_yang - 8
        if (pixie_code_to_checkout == 8)
        {
            if (bought_8 == 0)
            {
                if (money.money_amount >= price_8)
                {
                    money.money_amount -= price_8;
                    bought_8 = 1;
                    ins_bought_item.pixie_code_check = 8;

                    //save the money
                    PlayerPrefs.SetFloat("money", money.money_amount);

                    //save the pixie
                    PlayerPrefs.SetInt("yang_8",bought_8);
                }
            }
            else if (bought_8 == 1)
            {
                ins_bought_item.pixie_code_check = 8;
            }
        }
    }


    void Pixie_white_1()
    {
        if (pixie_code_to_checkout == 1)
        {
            text_title.text = title_1;

            if (bought_1 == 0)
            {
                text_price.text = "Price: " + price_1.ToString("N0") + "$$";
            }
            //if it s bought but not activated
            else if(bought_1 == 1 && ins_bought_item.pixie_code_check != 1)
            {
                text_price.text = "Tap to activate!";
            }
            //if it s both activated and bought
            else if(bought_1 == 1 && ins_bought_item.pixie_code_check == 1)
            {
                text_price.text = "Activated!";
            }

        }
    }

    void Pixie_blue_2()
    {
        if (pixie_code_to_checkout == 2)                //change here
        {
            text_title.text = title_2;

            if (bought_2 == 0)              //change here
            {
                text_price.text = "Price: " + price_2.ToString("N0") + "$$";        //change here
            }
            else if (bought_2 == 1 && ins_bought_item.pixie_code_check != 2)          //change here
            {
                text_price.text = "Tap to activate!" ;
            }
            else if (bought_2 == 1 && ins_bought_item.pixie_code_check == 2)          //change here
            {
                text_price.text = "Activated!";
            }
        }
    }

    void Pixie_green_3()
    {
        if (pixie_code_to_checkout == 3)                //change here
        {
            text_title.text = title_3;

            if (bought_3 == 0)              //change here
            {
                text_price.text = "Price: " + price_3.ToString("N0") + "$$";        //change here
            }
              
            else if (bought_3 == 1  && ins_bought_item.pixie_code_check != 3)          //change here
            {
                text_price.text = "Tap to activate!" ;
            }
            else if (bought_3 == 1 && ins_bought_item.pixie_code_check == 3)//change here
            {
                text_price.text = "Activated!";
            }
        }
    }

    void Pixie_purple_4()
    {
        if (pixie_code_to_checkout == 4)                //change here
        {
            text_title.text = title_4;

            if (bought_4 == 0)              //change here
            {
                text_price.text = "Price: " + price_4.ToString("N0") + "$$";        //change here
            }
            //if it s bought but not activated
            else if (bought_4 == 1 && ins_bought_item.pixie_code_check != 4)
            {
                text_price.text = "Tap to activate!";
            }
            //if it s both activated and bought
            else if (bought_4 == 1 && ins_bought_item.pixie_code_check == 4)
            {
                text_price.text = "Activated!";
            }
        }
    }

    void Pixie_red_5()
    {
        if (pixie_code_to_checkout == 5)                //change here
        {
            text_title.text = title_5;

            if (bought_5 == 0)              //change here
            {
                text_price.text = "Price: " + price_5.ToString("N0") + "$$";        //change here
            }
            //if it s bought but not activated
            else if (bought_5 == 1 && ins_bought_item.pixie_code_check != 5)
            {
                text_price.text = "Tap to activate!";
            }
            //if it s both activated and bought
            else if (bought_5 == 1 && ins_bought_item.pixie_code_check == 5)
            {
                text_price.text = "Activated!";
            }
        }
    }

    void Pixie_target_6()
    {
        if (pixie_code_to_checkout == 6)                //change here
        {
            text_title.text = title_6;

            if (bought_6 == 0)              //change here
            {
                text_price.text = "Price: " + price_6.ToString("N0") + "$$";        //change here
            }
            //if it s bought but not activated
            else if (bought_6 == 1 && ins_bought_item.pixie_code_check != 6)
            {
                text_price.text = "Tap to activate!";
            }
            //if it s both activated and bought
            else if (bought_6 == 1 && ins_bought_item.pixie_code_check == 6)
            {
                text_price.text = "Activated!";
            }
        }
    }

    void Pixie_red_glow_7()
    {
        if (pixie_code_to_checkout == 7)                //change here
        {
            text_title.text = title_7;

            if (bought_7 == 0)              //change here
            {
                text_price.text = "Price: " + price_7.ToString("N0") + "$$";        //change here
            }
            //if it s bought but not activated
            else if (bought_7 == 1 && ins_bought_item.pixie_code_check != 7)
            {
                text_price.text = "Tap to activate!";
            }
            //if it s both activated and bought
            else if (bought_7 == 1 && ins_bought_item.pixie_code_check == 7)
            {
                text_price.text = "Activated!";
            }
        }
    }

    void Pixie_yang_8()
    {
        if (pixie_code_to_checkout == 8)                //change here
        {
            text_title.text = title_8;

            if (bought_8 == 0)              //change here
            {
                text_price.text = "Price: " + price_8.ToString("N0") + "$$";        //change here
            }
            //if it s bought but not activated
            else if (bought_8 == 1 && ins_bought_item.pixie_code_check != 8)
            {
                text_price.text = "Tap to activate!";
            }
            //if it s both activated and bought
            else if (bought_8 == 1 && ins_bought_item.pixie_code_check == 8)
            {
                text_price.text = "Activated!";
            }
        }
    }
}
