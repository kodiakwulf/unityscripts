using UnityEngine;

public class FollowPlayer : MonoBehaviour {
	// "Offset" variable - position of camera
	public Transform player;
	public Vector3 offset;
	
	// Update is called once per frame
	void Update () {
		transform.position = player.position + offset;
	}
}
