using UnityEngine;
using System.Collections;

public class coinsGathered : MonoBehaviour {


    public TextMesh text;

    // coins used to buy upgrades;
    public static int coins;


    void Awake()
    {
        coinsGathered.coins = 100000;
    }


    void Update()
    {
        ShowCoins();
    }


    void ShowCoins()
    {
        if (text != null)
        {
            text.text = "Gc Collected: \n" + coins;
        }
    }
}
