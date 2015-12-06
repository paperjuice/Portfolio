using UnityEngine;
using System.Collections;

public class planetBehaviour : MonoBehaviour {

    private GameObject player;
    private GameObject camera;
    private GameObject[] obstacles;


    //tutorial only
    public GameObject tut;

    public GameObject sound_obs_destro;
    public GameObject obs_part_destro;


    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        camera = GameObject.FindGameObjectWithTag("MainCamera");
    }


    IEnumerator Start()
    {
        while (true)
        {
            obstacles = GameObject.FindGameObjectsWithTag("obstacle");

            yield return new WaitForSeconds(0.2f);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        foreach (GameObject obstacle in obstacles)
        {
            if (col.gameObject == obstacle)
            {
                //Debug.Log("asd");

                obs_part_destro.GetComponent<ParticleSystem>().startColor = obstacle.GetComponent<SpriteRenderer>().color;
                Instantiate(obs_part_destro, obstacle.transform.position, obs_part_destro.transform.rotation);
                Instantiate(sound_obs_destro, obstacle.transform.position, obs_part_destro.transform.rotation);
                if (tut != null)
                {
                    Instantiate(tut, obstacle.transform.position += new Vector3(3.5f,-1f,0f), obs_part_destro.transform.rotation);
                }

                player.GetComponent<playerBehaviour>().multiplier = 1;
                player.GetComponent<playerBehaviour>().lives--;
                player.GetComponent<playerBehaviour>().trigger_heart_shatter = true;

                camera.GetComponent<Animator>().SetTrigger("shake");

                Destroy(obstacle.gameObject);
            }
        }
    }
    
}
