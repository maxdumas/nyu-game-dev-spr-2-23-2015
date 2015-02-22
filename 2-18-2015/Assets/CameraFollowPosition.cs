using UnityEngine;
using System.Collections;

public class CameraFollowPosition : MonoBehaviour {
	public Transform[] Targets;
	public float LerpRatio = 0.125f;

	public Transform CurrentTarget;

	private int _currentTargetIndex;
	private Vector3 _initialOffset;

	// Use this for initialization
	void Start () {
		CurrentTarget = Targets[_currentTargetIndex];
		_initialOffset = transform.position - CurrentTarget.position;
	}

	void Update() {
	}

	// Update is called once per frame
	void OnPreRender () {
		transform.position = Vector3.Slerp(transform.position, CurrentTarget.position + _initialOffset, LerpRatio);
	}

	public void NextTarget() {
		if(_currentTargetIndex + 1 == Targets.Length)
			return;

		CurrentTarget = Targets[++_currentTargetIndex];
	}
}
