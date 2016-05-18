using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour {


	void OnTriggerEnter()
	{
		Application.LoadLevel ("Car");
	}
}
