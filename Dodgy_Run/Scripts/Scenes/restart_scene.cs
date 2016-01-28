using UnityEngine;
using System.Collections;


public class restart_scene : MonoBehaviour {

	public string level_name;


    void OnMouseDown()
    {
        Application.LoadLevel(level_name);
        score.score_ = 0;
    }
}
