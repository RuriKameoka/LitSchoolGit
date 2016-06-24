using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
	public GameObject goalObject;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		// Gameover
		if(transform.position.y <= -6){
			Debug.Log("Gameover");
			SceneManager.LoadScene ("Gameover");
		}

	}

	void OnCollisionEnter2D(Collision2D collision){
		// Goalの判定
		if(collision.gameObject.tag == "Goal"){
			Debug.Log("Goal");
			Destroy(collision.gameObject);
			Vector3 goalPosition = new Vector3(Random.Range(-2,2), Random.Range(-2,2), 0);
			Instantiate(goalObject, goalPosition, Quaternion.identity);
		}
	}
}
