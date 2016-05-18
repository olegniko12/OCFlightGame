using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {

	public GameObject explosion;

	void OnCollisionEnter(){
		GameObject expl = Instantiate (explosion, transform.position, Quaternion.identity) as GameObject;
		Destroy (gameObject);
		Destroy (expl, 10);
	}
}
