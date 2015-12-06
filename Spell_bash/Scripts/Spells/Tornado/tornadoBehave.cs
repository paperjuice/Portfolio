using UnityEngine;
using System.Collections;

public class tornadoBehave : MonoBehaviour {

    public GameObject blood;
    public float pushPower;
    public float slowPower;
    public float dmg;
    
    
    private float savedMs;
    private Rigidbody rigid;	
    private GameObject[] heroes;
    private GameObject[] gates;

    private GameObject red_tag;
    private GameObject blue_tag;
    
    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        heroes = GameObject.FindGameObjectsWithTag("Player");
        gates = GameObject.FindGameObjectsWithTag("hellGate");


        red_tag = GameObject.FindGameObjectWithTag("red");
        blue_tag = GameObject.FindGameObjectWithTag("blue");
        //Destroy(gameObject, 4f);
    }

    IEnumerator Start()
    {
        Vector3 move = transform.forward * pushPower;
        rigid.velocity = move;
        transform.position += transform.forward *2.7f;
        
        
        foreach(GameObject hero in heroes)
        {
            savedMs = hero.GetComponent<heroMovement>().ms/slowPower;
        }
        
        yield return new WaitForSeconds(4.9f);
        
        GetComponent<SphereCollider>().center += new Vector3(0,16f, 0);
        
    }
    
    
    void OnTriggerExit(Collider col)
    {
        foreach(GameObject hero in heroes)
        {
            if(col.gameObject == hero)
            {
                hero.GetComponent<heroMovement>().ms = hero.GetComponent<heroMovement>().savedMs;
            }
        }
    }

    void OnTriggerStay(Collider col)
    {
        foreach(GameObject hero in heroes)
        {
            if(col.gameObject == hero)
            {
                hero.GetComponent<heroStats>().health -= dmg * Time.deltaTime;
                hero.GetComponent<heroMovement>().ms = savedMs;
                Instantiate(blood, hero.transform.position, transform.rotation *= Quaternion.AngleAxis(180, Vector3.up));
            }
        }
        
        foreach(GameObject gate in gates)
        {
            if(col.gameObject == gate)
            {
                gate.GetComponent<hellGate_gate>().health-=dmg * Time.deltaTime;
            }
        }

        if (col.gameObject == red_tag)
        {
            red_tag.GetComponent<for_bar_dmg_part>().activate = true;
        }

        if (col.gameObject == blue_tag)
        {
            blue_tag.GetComponent<for_bar_dmg_part>().activate = true;
        }
    }
    
}
