using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

	private float speed = -0.2f;

	private float deadLine = -10;

	private AudioSource sound01;
	//AudioSource audio;

	int sound = 0;


	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "Block" || collision.gameObject.tag == "Ground") {
			if (sound == 0) {
				sound01.PlayOneShot(sound01.clip);
				sound++;
			} else {
				//audio.PlayOneShot(sound02);
				sound = 0;
			}
		}
	}


	// Use this for initialization
	void Start () {
		sound01 = GetComponent<AudioSource> ();
	}

	void Update (){

		transform.Translate (this.speed, 0, 0);

		if (transform.position.x < this.deadLine) {
			Destroy (gameObject);
		}


	}

}