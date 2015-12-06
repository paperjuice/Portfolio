using UnityEngine;
using System.Collections;

public class for_bar_dmg_part : MonoBehaviour {

    public GameObject bar;
    public bool activate;
    


    void Update()
    {
        if (activate == true)
        {
            if (bar.GetComponent<dmg_on_bar>().activate == false)
            {
                bar.GetComponent<dmg_on_bar>().activate =true;
                activate = false;
            }
        }
    }
}
