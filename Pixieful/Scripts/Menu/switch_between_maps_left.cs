using UnityEngine;
using System.Collections;

public class switch_between_maps_left : MonoBehaviour {

    private bool move = false;
    private Vector3 move_amount;

    public GameObject map;
    public float map_move_units_amount;

    public GameObject bottom_icons;
    public float icons_move_units_amount;

    //max to the left edge
    public float max_left;

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
                if (map.transform.position.x < 0)
                {
                    map.transform.position += new Vector3(map_move_units_amount, 0f, 0f);
                }
            }


            if (bottom_icons != null)
            {
                if (bottom_icons.transform.position.x < max_left)
                {
                    bottom_icons.transform.position += new Vector3(icons_move_units_amount, 0f, 0f);
                }
            }

            //move_amount = map.transform.position + new Vector3(15f, 0f, 0f);
            // map.transform.position = Vector3.Lerp(map.transform.position, move_amount, Time.deltaTime * 5f);
            move = false;
        }
        

    }

       

}
