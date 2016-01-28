using UnityEngine;
using System.Collections;

public class ins_coins : MonoBehaviour {

    private float time;

    public GameObject coins;
    public float cd;
    public float ms;




    void Update()
    {
        //Movement();
        Ins_coins();
    }

    void Movement()
    {
        if (ms <= 17f)
        {
            ms += Time.deltaTime * 0.2f;
        }
        transform.position += transform.forward * ms * Time.deltaTime;
    }

    void Ins_coins()
    {
        time += Time.deltaTime;

        if (time >= cd)
        {
            Instantiate(coins, coins.transform.position = new Vector3(Random.Range(-3, 3), transform.position.y, transform.position.z), transform.rotation);
            time = 0f;
        }
    }
}
