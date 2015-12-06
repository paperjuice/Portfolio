using UnityEngine;
using System.Collections;

public class hero_attack_at_mouse_po : MonoBehaviour {



    private int mask;
    private RaycastHit raycast;

    private bool is_on_cd;
    private float time;
    public float cd;

    public GameObject spell;
    public KeyCode key;

    void Awake()
    {
        mask = LayerMask.GetMask("floor");
    }



    void Update()
    {
        Ins_at_mouse_pos();
        Cooldown();
    }

    void Ins_at_mouse_pos()
    {
        Ray mouse_pos = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetKeyDown(key))
        {
            if (Physics.Raycast(mouse_pos, out raycast, 1000f, mask))
            {
                if (is_on_cd == false)
                {
                    Instantiate(spell, raycast.point - new Vector3(0f,2f, 0f), transform.rotation);
                    is_on_cd = true;
                }
            }
        }
    }

    void Cooldown()
    {
        if (is_on_cd == true)
        {
            time += Time.deltaTime;

            if (time >= cd)
            {
                is_on_cd = false;
                time = 0f;
            }
        }
    }
}
