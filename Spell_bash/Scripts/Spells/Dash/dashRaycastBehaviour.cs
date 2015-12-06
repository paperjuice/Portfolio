using UnityEngine;
using System.Collections;

public class dashRaycastBehaviour : MonoBehaviour {

	public GameObject particles;
	public float teleportDistance;
	
	private Ray fromRay;
	private RaycastHit raycast;
	private int layerMask;
	
	
	
	
	void Update()
	{
		fromRay.origin = transform.position;
		fromRay.direction = transform.forward;
	
		if(Input.GetKeyDown("f"))
		{
			Instantiate(particles, transform.position, transform.rotation);
		
		
			if(Physics.Raycast(fromRay, out raycast, teleportDistance))
			{
				transform.position = new Vector3( raycast.point.x, 0, (raycast.point.z ));
			}
			else
			{
				transform.position += transform.forward * teleportDistance;
			}
		}
	}
}
