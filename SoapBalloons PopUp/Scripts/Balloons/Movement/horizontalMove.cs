using UnityEngine;
using System.Collections;

public class horizontalMove : MonoBehaviour {

	public float timeToMoveUntilChangeDirection;
	public float speed;
	
	private bool move;
	
	IEnumerator Start()
	{
		while(true)
		{
			move=true;
			
			yield return new WaitForSeconds(timeToMoveUntilChangeDirection);
			
			move = false;
			
			yield return new WaitForSeconds(timeToMoveUntilChangeDirection);
		}
		
	}
	
	void Update()
	{
		if(move == true)
		{
			transform.position += transform.right * speed * Time.deltaTime;
		}
		else
		{
			transform.position += transform.right * -speed * Time.deltaTime;;
		}
	}
}
