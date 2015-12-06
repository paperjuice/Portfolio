using UnityEngine;
using System.Collections;

public class tutorial : MonoBehaviour {

    private bool fade_in = false;
    public float alpha = 1f;

    void Update()
    {
        Fade_in_activator();
        Fade_in_on();
    }

    void Fade_in_activator()
    {
        if (Input.GetButtonDown(buttonName: "Fire1"))
        {
            fade_in = true;
        }
    }

    void Fade_in_on()
    { 
        if(fade_in == true)
        {
            
            alpha -= Time.deltaTime * 0.5f;
            GetComponent<TextMesh>().color = new Color(1, 1, 1, alpha);

            if (alpha <= 0)
            {
                Destroy(gameObject);
            }
        }
    }



}
