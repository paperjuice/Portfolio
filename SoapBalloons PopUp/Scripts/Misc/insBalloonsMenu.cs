using UnityEngine;
using System.Collections;

public class insBalloonsMenu : MonoBehaviour {

	public GameObject balloons;
	
	IEnumerator Start()
	{
		while(true)
		{
			float h = Random.Range(0.2f, 1.5f ) ;
			Instantiate(balloons, transform.position = new Vector2(Random.Range(-3.5f, 3.5f), transform.position.y), transform.rotation = Quaternion.AngleAxis(Random.Range(0, 200), Vector3.forward));
			yield return new WaitForSeconds(h);
		}	
	}
}
