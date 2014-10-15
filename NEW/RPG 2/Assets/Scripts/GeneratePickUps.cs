using UnityEngine;
using System.Collections;

public class GeneratePickUps : MonoBehaviour 
{
	public GameObject pickUpTime;
	public GameObject pickUpMoney;
	public GameObject pickUpEnergy;

	Vector3 theNewPos = new Vector3(Random.Range(0, 2000),1,Random.Range(0, 2000));

	// Use this for initialization
	void Start () {
		for (int i = 0; i < 20; i++) {
			theNewPos = new Vector3(Random.Range(0, 2000),1,Random.Range(0, 2000));
			Instantiate(pickUpTime, theNewPos, transform.rotation);

			theNewPos = new Vector3(Random.Range(0, 2000),1,Random.Range(0, 2000));
			Instantiate(pickUpMoney, theNewPos, transform.rotation);

			theNewPos = new Vector3(Random.Range(0, 2000),1,Random.Range(0, 2000));
			Instantiate(pickUpEnergy, theNewPos, transform.rotation);
		}
	}
}