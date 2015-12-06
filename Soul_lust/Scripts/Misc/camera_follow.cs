using UnityEngine;
using System.Collections;

public class camera_follow : MonoBehaviour {

    private GameObject player;

    public bool camera_boss_mode;
    public float damp_ammount; //cat se duce in parti
    public float smooth_speed;
    public float y; //pozitia pe verticala
    public float z; //potrivit


    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        Boss_mode_off();
        Boss_mode_on();
    }

    void LateUpdate()
    {
     //   Camera_smooth();
        Camera_fix();
    }

    void Camera_smooth()
    {
       // transform.position = new Vector3(player.transform.position.x, y, player.transform.position.z +z);
        if (player != null)
        {
            if (Input.GetKey(player.GetComponent<hero_movement>().move_up))
            {
                Vector3 upSmooth = new Vector3(player.transform.position.x, y, player.transform.position.z + z + damp_ammount);

                transform.position = Vector3.Lerp(transform.position, upSmooth, smooth_speed);
            }

            if (Input.GetKey(player.GetComponent<hero_movement>().move_down))
            {
                Vector3 upSmooth = new Vector3(player.transform.position.x, y, player.transform.position.z + z - damp_ammount);

                transform.position = Vector3.Lerp(transform.position, upSmooth, smooth_speed);
            }

            if (Input.GetKey(player.GetComponent<hero_movement>().move_right))
            {
                Vector3 upSmooth = new Vector3(player.transform.position.x + damp_ammount, y, player.transform.position.z + z);

                transform.position = Vector3.Lerp(transform.position, upSmooth, smooth_speed);
            }

            if (Input.GetKey(player.GetComponent<hero_movement>().move_left))
            {
                Vector3 upSmooth = new Vector3(player.transform.position.x - damp_ammount, y, player.transform.position.z + z);

                transform.position = Vector3.Lerp(transform.position, upSmooth, smooth_speed);
            }
        }
    }

    void Camera_fix()
    {
        if (player != null)
        {
            transform.position = new Vector3(player.transform.position.x, y, player.transform.position.z + z);
        }
    }

    void Boss_mode_on()
    {
        if (camera_boss_mode == true)
        {
            if (y <= 80)
            {
                y += Time.deltaTime* 20;
            }
            if (z >= -22)
            {
                z -= Time.deltaTime * 10;
            }
        }
    }

    void Boss_mode_off()
    {
        if (camera_boss_mode == false)
        {
            if (y >= 30)
            {
                y -= Time.deltaTime * 20;
            }
            if (z <= -10)
            {
                z += Time.deltaTime * 10;
            }
        }
    }
}
