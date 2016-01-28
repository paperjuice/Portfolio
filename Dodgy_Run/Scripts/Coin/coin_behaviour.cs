using UnityEngine;
using System.Collections;

public class coin_behaviour : MonoBehaviour {

    public float rs;

    [SerializeField]
    public static int score;
    private GameObject player;


    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * rs);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject == player)
        {
            score++;
            Destroy(gameObject);
        }
    }
}
