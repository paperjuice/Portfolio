using UnityEngine;
using System.Collections;

public class destroy_if_upsideDown : MonoBehaviour {

    public GameObject player;
    private GameObject[] grounds;





    IEnumerator Start()
    {
        while (true)
        {

            grounds = GameObject.FindGameObjectsWithTag("ground");

            yield return new WaitForSeconds(0.1f);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        foreach (GameObject ground in grounds)
        {
            if (col.gameObject == ground)
            {
                Destroy(player.gameObject);
                print("pula mea");
            }
        }
    }



}
