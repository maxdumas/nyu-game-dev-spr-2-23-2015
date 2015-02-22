using UnityEngine;
using System.Collections;

public class EndGame : MonoBehaviour {
	public GameObject Candles;
	public Light MainLight;
	public float TargetY = -7.61f;
	public Color TargetBGColor;
	public TextMesh Text;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision) {
		Debug.Log ("Farquad");
		Candles.SetActive(true);
		StartCoroutine(MoveCandlesUp());
	}

	IEnumerator MoveCandlesUp() {
		while(Candles.transform.position.y < TargetY) {
			MainLight.intensity = Mathf.SmoothStep(MainLight.intensity, 0.25f, 0.05f);
			Camera.main.backgroundColor = Color.Lerp(Camera.main.backgroundColor, TargetBGColor, 0.125f);
			Candles.transform.position += Vector3.up * Time.deltaTime;
			yield return new WaitForEndOfFrame();
		}
		Text.gameObject.SetActive(true);
	}
}
