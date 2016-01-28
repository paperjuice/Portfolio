using UnityEngine;
using System.Collections;

public class visible_if_in_range : MonoBehaviour {

    private GameObject[] panels;


    void Awake()
    {
        panels = GameObject.FindGameObjectsWithTag("panel");
    }

    void Update()
    {
        foreach (GameObject panel in panels)
        {
            if (Vector2.Distance(transform.position, panel.transform.position) < 5)
            {
                panel.gameObject.SetActive(true);
            }
            else
            {
                panel.gameObject.SetActive(false);
            }
        }
    }
}
