using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {


    public float ms;

    private Animator anim;
    
    

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {

        Move_v2();
        Animation();

    }

    void Move_v2()
    {
        if (Input.GetKey("d"))
        {
           transform.rotation = Quaternion.AngleAxis(0, Vector2.up);
            transform.position += Vector3.right * ms * Time.deltaTime;
   
            anim.SetBool("move", true);
        }
        
        if (Input.GetKey("a"))
        {
            transform.rotation = Quaternion.AngleAxis(180, Vector2.up);
            transform.position += transform.right * ms * Time.deltaTime;
        }
    }

    void Animation()
    {
        if (Input.GetKey("a") || Input.GetKey("d"))
        {
            anim.SetBool("move", true);
        }
        else 
        {
            anim.SetBool("move", false);
        }
    }




    


   

}
