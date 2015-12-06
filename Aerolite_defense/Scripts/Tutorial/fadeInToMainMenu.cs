using UnityEngine;
using System.Collections;

public class fadeInToMainMenu : MonoBehaviour {

    //public GameObject tab;
    public GameObject endText;
    public float secondsTillStart;

    private bool fadeIn;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(secondsTillStart);

        fadeIn = true;

        yield return new WaitForSeconds(1f);

        endText.SetActive(true);

        yield return new WaitForSeconds(10f);

        Application.LoadLevel("MainMenu");
    }

    void Update()
    {
        if (fadeIn == true)
        {
            Color col = GetComponent<SpriteRenderer>().color;
            col.a += Time.deltaTime;
            GetComponent<SpriteRenderer>().color = col;

        }
    }
}
