using UnityEngine;
using System.Collections;

public class LineGenerater : MonoBehaviour {
	[SerializeField]
	bool isPressed;

	Vector3 startPressPosition;
	Vector3 endPressPosition;

	public GameObject lineObject;

	// Use this for initialization
	void Start () {
		isPressed =false;
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			Vector3 tempPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y,10);
			startPressPosition = Camera.main.ScreenToWorldPoint(tempPosition);
			Instantiate(lineObject,startPressPosition,Quaternion.identity);

			Debug.Log(startPressPosition);

			isPressed = true;
		}

		if(Input.GetMouseButton(0)){

		}

		if(Input.GetMouseButtonUp(0)){
			Vector3 tempPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y,10);
			endPressPosition = Camera.main.ScreenToWorldPoint(tempPosition);

			generateLine();

			isPressed = false;
		}

	}

	//リアルタイムで描画しない場合
	void generateLine(){

		//Instantiate
		//enabled = false
		//SetVertexCount = 2
		//setPositions
		//enabled = true

	}
}
