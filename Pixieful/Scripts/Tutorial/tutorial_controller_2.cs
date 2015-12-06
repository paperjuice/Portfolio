using UnityEngine;
using System.Collections;

public class tutorial_controller_2 : MonoBehaviour {

    private float a = 255f;
    private bool fade_out = false;

    public GameObject congrats;


    IEnumerator Start()
    {
        yield return new WaitForSeconds(2f);

        GetComponent<rotate_behaviour>().enabled = true;

        yield return new WaitForSeconds(10f);

        fade_out = true;

        
        
       
    }


    void Update()
    {
        if (fade_out == true)
        {
            print("sad");
           // a = GetComponent<SpriteRenderer>().color;
            //a.a -= Time.deltaTime * 0.5f;
            //GetComponent<SpriteRenderer>().color = a;

            a -= Time.deltaTime * 50f;
            GetComponent<SpriteRenderer>().color = new Color32(3, 69, 83, (byte)a);

            if (a < 0)
            {
                Destroy(gameObject);
                congrats.gameObject.SetActive(true);
            }
        }

       
    }
}
