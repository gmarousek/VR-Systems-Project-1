using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {

	public GameObject[] cameraPoints;
	public GameObject camera;
	private bool next;
	private int index;
	private GameObject point;
	public float speed;
	public float look;

	// Use this for initialization
	void Start () {
		next = true;
		index = 0;
		point = cameraPoints [0];
	}
	
	// Update is called once per frame
	void Update () {
		if (index == 12 && camera.transform.position == point.transform.position) {
			index++;
			point = cameraPoints [index];

			camera.transform.position = point.transform.position;
			camera.transform.rotation = Quaternion.Lerp (camera.transform.rotation, point.transform.rotation, look);

		} else {
			if (next && index <= 19) {
				point = cameraPoints [index];
				next = false;

			} else if (camera.transform.position == point.transform.position) {
				next = true;
				index++;
			}
			if (index <= 20) {
				camera.transform.position = Vector3.MoveTowards (camera.transform.position, point.transform.position, speed);
				camera.transform.rotation = Quaternion.Lerp (camera.transform.rotation, point.transform.rotation, look);
			}
		}
	}
}
