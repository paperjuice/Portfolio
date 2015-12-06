using UnityEngine;
using System.Collections;
using System;

public class tokkens : MonoBehaviour
{

    private float time;
    private float end_time=6f;

    public static int tokken;

    public TextMesh text;
    public GameObject ad;

    void Awake()
    {
        tokken = PlayerPrefs.GetInt("tokkens");
    }

    void Update()
    {
        if (tokken == 1)
        {
            text.text = tokken + " tokken left";
        }

        if (tokken > 1 || tokken == 0)
        {
            text.text = tokken + " tokkens left";
        }

        if (tokken == 0)
        {
            time += Time.deltaTime;
            if (time >= end_time)
            {
                ad.gameObject.SetActive(true);
            }
        }
        else
        {
            ad.gameObject.SetActive(false);
        }
    }
}
