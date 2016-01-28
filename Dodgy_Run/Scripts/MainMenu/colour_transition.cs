using UnityEngine;
using System.Collections;

public class colour_transition : MonoBehaviour {

    int i = 0;
    private TextMesh colour;

    private float time = 2f;

    public  Color32[] col =  new Color32[5];

    void Awake()
    {
        colour = GetComponent<TextMesh>(); 
    }

    IEnumerator Start()
    {
        while (true)
        {
            for (i = 0; i < col.Length; i++)
            {
                
                yield return new WaitForSeconds(2f);
            }
        }
    }

    void Update()
    {
        colour.color = Color.Lerp(colour.color, col[i], Time.deltaTime);
    }

}
