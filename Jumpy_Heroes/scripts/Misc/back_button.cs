using UnityEngine;
using System.Collections;

public class back_button : MonoBehaviour
{

    [SerializeField]
    private string level_name;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.LoadLevel(level_name);
        }
    }
}