using UnityEngine;
using System.Collections;

public class switch_between_maps_right : MonoBehaviour {

    private bool move = false;
    private Vector3 move_amount;


    //map
    public GameObject map;
    public float max_to_the_right_map;
    public float map_move_units_amount;

    //icons
    public GameObject bottom_icons;
    public float max_to_the_right_icons;
    public float icons_move_units_amount;

    void OnMouseDown()
    {
        move = true;
    }

    void Update()
    {
        Move_to_the_right();
    }

    void Move_to_the_right()
    {

        if (move == true)
        {
            if (map != null)
            {
                if (map.transform.position.x > -max_to_the_right_map)
                {
                    map.transform.position -= new Vector3(map_move_units_amount, 0f, 0f);
                }
            }

            if (bottom_icons != null)
            {
                if (bottom_icons.transform.position.x > max_to_the_right_icons)
                {
                    bottom_icons.transform.position -= new Vector3(icons_move_units_amount, 0f, 0f);
                }
            }
           // move_amount = map.transform.position- new Vector3(15f, 0f, 0f);
          //  map.transform.position = Vector3.Lerp(map.transform.position, move_amount, Time.deltaTime * 5f);
            move = false;
        }

    }


}
