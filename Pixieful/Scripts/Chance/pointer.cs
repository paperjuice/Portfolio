using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class pointer : MonoBehaviour
{
    private GameObject[] pies;
    private float time = 0;
    private float end_time;

    public bool go_rotate = false;
    public bool roll_random;
    public GameObject wheel;
    public float rs;


    void Awake()
    {
        pies = GameObject.FindGameObjectsWithTag("pie");
    }

    void Update()
    {
        Rotate();
        Roll_for_random();
    }


    void Roll_for_random()
    {
        if (roll_random == true)
        {
            rs = Random.Range(500, 640);
            roll_random = false;
        }
    }

    void Rotate()
    {
        if (go_rotate == true)
        {
            if (rs >= 2)
            {
                rs -= Time.deltaTime * 69f;
                wheel.transform.Rotate(Vector3.forward * Time.deltaTime * -rs);
            }

            if (rs < 2 && rs > 1)
            {

                GetComponent<CircleCollider2D>().enabled = true;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        foreach (GameObject pie in pies)
        { 
            if(col.gameObject == pie)
            {
                print(pie.GetComponent<pie_piece>().prize);
            }
        }
    }
}
