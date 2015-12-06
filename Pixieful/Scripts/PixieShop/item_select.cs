using UnityEngine;
using System.Collections;

public class item_select : MonoBehaviour {


    private GameObject[] pixies_tag;
    private GameObject frame_select;
    private GameObject pixie_movement;
    private GameObject checkout;

    public GameObject pixie;

    //so you know what you buy 
    public int pixie_code;


    void Awake()
    {
        pixie_movement = GameObject.FindGameObjectWithTag("pixie_movement");
        frame_select = GameObject.FindGameObjectWithTag("frame_select");
        checkout = GameObject.FindGameObjectWithTag("checkout");
    }

    IEnumerator Start()
    {
        frame_select.transform.parent = gameObject.transform;
        frame_select.transform.localPosition = new Vector3(-23f, 0.23f, 0f);

        while (true)
        {
            pixies_tag = GameObject.FindGameObjectsWithTag("pixie");

            yield return new WaitForSeconds(0.1f);
        }
    }

    void OnMouseDown()
    {
        //print("asd");

        //delive the code to checkout
        checkout.GetComponent<price_check_out>().pixie_code_to_checkout = pixie_code;

        foreach (GameObject pixie_tag in pixies_tag)
        {
            Destroy(pixie_tag.gameObject);
        }

        Instantiate(pixie, pixie_movement.transform.position, transform.rotation);
       // frame_select.transform.position = transform.position - new Vector3(0f,-0.13f,0f);

        //set the frame on clicked position
        frame_select.transform.parent = gameObject.transform;
        frame_select.transform.localPosition = new Vector3(0f, 0.23f, 0f);

    }

}
