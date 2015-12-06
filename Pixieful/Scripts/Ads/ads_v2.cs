using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class ads_v2 : MonoBehaviour {


    void Awake()
    {
        Advertisement.Initialize("1019045", true);

    }

    void OnMouseDown()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
        else
        {
            print("wait for a bit");
        }
    }

}
