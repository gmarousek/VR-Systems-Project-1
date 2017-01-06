using UnityEngine;
//using System.Collections;

public class Stereoscopy : MonoBehaviour {

	Camera camera1;
//	Camera camera2;
	public float ipd;
//	Vector3 pos1;
//	Vector3 pos2;


	// Use this for initialization
	void Start () {
		if (camera1 == null) {
			camera1 = Instantiate (Camera.main);
			camera1.GetComponent<Stereoscopy> ().enabled = false;
			camera1.GetComponent<CameraMove> ().enabled = false;

			Camera.main.transform.position = new Vector3 (
				Camera.main.transform.position.x - (ipd / 2),
				Camera.main.transform.position.y,
				Camera.main.transform.position.z);

			camera1.transform.parent = Camera.main.transform;
			camera1.transform.position = new Vector3 (
				Camera.main.transform.position.x + (ipd / 2),
				Camera.main.transform.position.y,
				Camera.main.transform.position.z);
		}

		Camera.main.rect = new Rect (0, 0, .5f, 1);
		camera1.rect = new Rect (.5f, 0, 1, 1);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
