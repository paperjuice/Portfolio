using UnityEngine;
using System.Collections;

public class ins_bought_item : MonoBehaviour {

    public static int pixie_code_check = 1;

    public GameObject pixie_white_1;
    public GameObject pixie_blue_2;
    public GameObject pixie_green_3;
    public GameObject pixie_purple_4;
    public GameObject pixie__red_5;
    public GameObject pixie_target_6;
    public GameObject pixie_red_glow_7;
    public GameObject pixie_yahng_8;


    void Awake()
    {
        if (pixie_code_check == 1)
        {
            Instantiate(pixie_white_1, transform.position, transform.rotation);
        }

        if (pixie_code_check == 2)
        {
            Instantiate(pixie_blue_2, transform.position, transform.rotation);
        }

        if (pixie_code_check == 3)
        {
            Instantiate(pixie_green_3, transform.position, transform.rotation);
        }

        if (pixie_code_check == 4)
        {
            Instantiate(pixie_purple_4, transform.position, transform.rotation);
        }

        if (pixie_code_check == 5)
        {
            Instantiate(pixie__red_5, transform.position, transform.rotation);
        }

        if (pixie_code_check == 6)
        {
            Instantiate(pixie_target_6, transform.position, transform.rotation);
        }

        if (pixie_code_check == 7)
        {
            Instantiate(pixie_red_glow_7, transform.position, transform.rotation);
        }

        if (pixie_code_check == 8)
        {
            Instantiate(pixie_yahng_8, transform.position, transform.rotation);
        }
    }

}
