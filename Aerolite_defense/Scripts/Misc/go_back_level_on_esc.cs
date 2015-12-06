using UnityEngine;
using System.Collections;

public class go_back_level_on_esc : MonoBehaviour {


    public string levelName;


    void Update()
    {
        //press secape key to change level
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.LoadLevel(levelName);
        }
    }


}
