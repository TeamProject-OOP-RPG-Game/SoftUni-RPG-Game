using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour
{	
	public Slider energySlider;
	public Slider timeSlider;
	public Text moneyText;
	private double defaultMoney;

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.tag == "PickUpEnergy")
		{
			other.gameObject.SetActive(false);
			energySlider.value = 100;
		}
		else if (other.gameObject.tag == "PickUpTime") 
		{
			other.gameObject.SetActive(false);
			timeSlider.value = 100;
		}
		else if (other.gameObject.tag == "PickUpMoney") 
		{
			other.gameObject.SetActive(false);
			defaultMoney = double.Parse(moneyText.text);
			defaultMoney = defaultMoney + 100;
			moneyText.text = defaultMoney.ToString();
		}
	}

}