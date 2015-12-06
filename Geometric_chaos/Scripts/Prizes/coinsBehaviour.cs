using UnityEngine;
using System.Collections;

public class coinsBehaviour : MonoBehaviour {

    private Rigidbody2D rigid;
    private GameObject player;
    private Animator anim;

    public float rs;
    public float power;


    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        anim = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody2D>();
    }

    IEnumerator Start()
    {
        ForcePush();

        yield return new WaitForSeconds(10.0f);

        anim.SetTrigger("fade");

        yield return new WaitForSeconds(3.0f);

        Destroy(gameObject);

    }

    void Update()
    {
        Rotate();
       
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject == player)
        {
            Destroy(gameObject);
            coinsGathered.coins += 1 + player.GetComponent<shipSts>().level;
        }
    }


    void Rotate()
    {
        transform.Rotate(rs * Vector3.forward);
    }

    void ForcePush()
    {
        rigid.AddForce(transform.up  * power);
    }


}
