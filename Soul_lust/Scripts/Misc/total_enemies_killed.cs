using UnityEngine;
using System.Collections;

public class total_enemies_killed : MonoBehaviour {

    public int small_enemies_killed;

    void Update()
    {
        GetComponent<TextMesh>().text = "Enemies Killed:\n" + small_enemies_killed;
    }
}
