using UnityEngine;
using System.Collections;

public class LineObject : MonoBehaviour {
	Vector3 endPressPosition;
	Vector3 nowPressPosition;

	LineRenderer lineRenderer;
	public bool isPressed;

	int lineObjectNum;

	// Use this for initialization
	void Start () {
		lineRenderer = this.GetComponent<LineRenderer>();
		lineRenderer.SetVertexCount(2);
		lineRenderer.enabled = false;
		lineRenderer.SetPosition(0,transform.position);


		isPressed = true;
	}

	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButton(0) && isPressed){
			Vector3 tempPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y,10);
			nowPressPosition = Camera.main.ScreenToWorldPoint(tempPosition);
			lineRenderer.SetPosition(1,nowPressPosition);
			lineRenderer.enabled = true;


		}

		if(Input.GetMouseButtonUp(0)){
			Vector3 tempPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y,10);
			endPressPosition = Camera.main.ScreenToWorldPoint(tempPosition);
			Debug.Log(endPressPosition);

			isPressed = false;

		}
	}
}
