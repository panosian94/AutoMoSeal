using UnityEngine;

/// <summary>
/// Ronald was here ;D 
/// </summary>


public class GroundControl : MonoBehaviour {
    float speed = .5f;
	
	// Update is called once per frame
	void Update () {
        float offset = Time.time * speed;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(1, -offset);
	}
}
