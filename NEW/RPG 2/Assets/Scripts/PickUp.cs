using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour, IMoveable {
	
	// Update is called once per frame
	void Update () {
		Move ();
	}

	public void Move()
	{
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
	}


}
