using UnityEngine;
using System.Collections;

public class showCoins : MonoBehaviour {

    public TextMesh coins;

    void Update()
    {
        coins.text = "Geometric coins: " + coinsGathered.coins.ToString("N0");
    }
}
