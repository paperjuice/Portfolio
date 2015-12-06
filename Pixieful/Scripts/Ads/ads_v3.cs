using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class ads_v3 : MonoBehaviour {

    public TextMesh text;



    void Start()
    {
        Advertisement.Initialize("1019279", false);
    }

    void OnMouseDown()
    {
        if (Advertisement.IsReady("rewardedVideo"))
        {
            var options = new ShowOptions { resultCallback = HandleShowResult };
            Advertisement.Show("rewardedVideo", options);
            //text.text = "merge ad";
        }
        else
        {
            print("nu reclame");
            //text.text = "iei muie";
        }
    }

    private void HandleShowResult(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                Debug.Log("The ad was successfully shown.");
                
                //here are my rewards for seeing the comercial
                tokkens.tokken++;
                PlayerPrefs.SetInt("tokkens", tokkens.tokken);

                //
                break;
            case ShowResult.Skipped:
                Debug.Log("The ad was skipped before reaching the end.");
                break;
            case ShowResult.Failed:
                Debug.LogError("The ad failed to be shown.");
                break;
        }
    }

}
