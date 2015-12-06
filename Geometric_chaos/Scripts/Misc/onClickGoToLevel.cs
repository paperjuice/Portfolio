using UnityEngine;
using System.Collections;

public class onClickGoToLevel : MonoBehaviour {

    public string levelName;


    void OnMouseDown()
    {
        Application.LoadLevel(levelName);
    }

    void OnMouseEnter()
    {
        GetComponent<SpriteRenderer>().color += new Color(0.3f, 0f, 0f, 0f);
    }

    void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().color -= new Color(0.3f, 0f, 0f, 0f);
    }
}
