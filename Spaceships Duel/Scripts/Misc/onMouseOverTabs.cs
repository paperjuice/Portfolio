using UnityEngine;
using System.Collections;

public class onMouseOverTabs : MonoBehaviour {


    private SpriteRenderer sprite;


    public GameObject destroPart;
    public GameObject part;
    public string levelName;


    void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
    }


    void OnMouseEnter()
    {
        sprite.color += new Color32(50, 0, 0, 0);
        part.SetActive(true);
        Instantiate(destroPart, transform.position, transform.rotation);
        transform.localScale += new Vector3(0.09f, 0.05f, 0);
    }

    void OnMouseExit()
    {
        sprite.color -= new Color32(50, 0, 0, 0);
        part.SetActive(false);
        transform.localScale -= new Vector3(0.09f, 0.05f, 0);
    }

    void OnMouseDown()
    {
        transform.localScale -= new Vector3(0.15f, 0.05f, 0);
        Application.LoadLevel(levelName);
    }
}
