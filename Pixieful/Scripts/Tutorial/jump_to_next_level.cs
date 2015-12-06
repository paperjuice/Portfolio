using UnityEngine;
using System.Collections;

public class jump_to_next_level : MonoBehaviour {

    IEnumerator Start()
    {
        yield return new WaitForSeconds(4f);

        Application.LoadLevel("Scene_1");
    }
}
