using UnityEngine;
using System.Collections;

public class insPower : MonoBehaviour {

    private float time = 0;                    
    private GameObject player;

    public GameObject audiSFX;
    public GameObject iconFill;         //iconFill
    public GameObject power;              //power to be ins
    public string playerTag;            //the player tag
    public KeyCode powerKey;            //key to be pressed
    public float cd;                     //how many seconds till next use;
    public int healthCost;            //the health you have to pay for using power



    void Awake()
    {
        player = GameObject.FindGameObjectWithTag(playerTag);
    }


    void Update()
    {
        InstantiatePower();
        ApplyCd();
        CoolDownIcon();
    }


    void InstantiatePower()
    {
        if (Input.GetKeyDown(powerKey))
        {
            if (healthCost <= player.GetComponent<playerSts>().health)
            {
                if (time <= 0)
                {
                    Instantiate(power, transform.position, transform.rotation);
                    Instantiate(audiSFX, transform.position, transform.rotation);
                    player.GetComponent<playerSts>().health -= healthCost;
                    time = cd;
                }
            }
        }
    }

    void ApplyCd()
    {
        if (time >= 0)
        {
            time -= Time.deltaTime;
        }
    }

    void CoolDownIcon()
    {
        iconFill.transform.localScale = new Vector3(iconFill.transform.localScale.x, time / cd, 1f);
    }
}
