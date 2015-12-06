using UnityEngine;
using System.Collections;

public class money : MonoBehaviour {


	[SerializeField]
	public static float money_amount;

    public TextMesh text;

    void Start()
    {
        money_amount = PlayerPrefs.GetFloat("money");
    }

    void Update()
    {
        text.text = "" + money_amount.ToString("N0") + "$$";
    }
}
