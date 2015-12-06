using UnityEngine;
using System.Collections;

public class acidDmg : MonoBehaviour {

    private GameObject hero;
    private GameObject red_tag;
    private GameObject blue_tag;
    
    public string heroTagColor;

    
    void Awake()
    {
        hero = GameObject.FindGameObjectWithTag(heroTagColor);

        red_tag = GameObject.FindGameObjectWithTag("red");
        blue_tag = GameObject.FindGameObjectWithTag("blue");
    }

    IEnumerator Start()
    {
        Destroy(gameObject, 5.1f);
    
        transform.position += transform.forward * 6f;
        
        yield return new WaitForSeconds(5);
        
        GetComponent<BoxCollider>().center = new Vector3(0, 15f, 0f);
        
    }
    
    void OnTriggerStay(Collider col)
    {
        if(col.gameObject == hero)
        {
            hero.GetComponent<acidDmgOnPlayer>().dealDmg = true;
        }

        if (col.gameObject == hero)
        {
            hero.GetComponent<for_bar_dmg_part>().activate = true;
        }

       
    }
    
    void OnTriggerExit()
    {
        hero.GetComponent<acidDmgOnPlayer>().dealDmg = false;
    }
}
