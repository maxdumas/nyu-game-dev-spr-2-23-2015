using UnityEngine;
using System.Collections;

public class CameraFollowee : MonoBehaviour {
	public CameraFollowPosition Follower;
	public Collider ValidBounds; // Follower moves to next target when this object exits these bounds

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerExit(Collider other) {
		if(other == ValidBounds) {
			Debug.Log (this.transform.parent.gameObject);
			Follower.NextTarget();
		}
	}
}
