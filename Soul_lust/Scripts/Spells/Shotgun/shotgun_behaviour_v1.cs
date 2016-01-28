using UnityEngine;
using System.Collections;

public class shotgun_behaviour_v1 : MonoBehaviour {

    private GameObject[] enemies;

    public GameObject dmg_text;
    public float dmg;


    void Awake()
    {
        enemies = GameObject.FindGameObjectsWithTag("enemy");
    }

    void OnTriggerEnter(Collider col)
    {
        foreach (GameObject enemy in enemies)
        {
            if (col.gameObject == enemy)
            {
                enemy.GetComponent<enemy_behaviour>().health -= dmg;
                dmg_text.GetComponent<TextMesh>().text = "" + dmg;
                Instantiate(dmg_text, enemy.transform.position, transform.rotation = Quaternion.Euler(new Vector3(65f, 0, 0)));
            }
        }
    }


}
