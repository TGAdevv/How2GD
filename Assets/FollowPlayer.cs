using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public float baseHeight = -2.3f;

    public Transform player;
    public Movement playerScript;

    float velocity = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 newVector = Vector3.back * 10;

        newVector += Vector3.right * (player.position.x + 3.4f);

        if (player.transform.position.y > 4.2f + baseHeight && playerScript.CurrentGamemode == Gamemodes.Cube)
            newVector += Vector3.up * Mathf.SmoothDamp(transform.position.y, player.position.y - (4.2f + baseHeight), ref velocity, 0.3f);
        else if (Camera.main.transform.position.y > 0 && playerScript.CurrentGamemode == Gamemodes.Cube)
            newVector += Vector3.up * Mathf.SmoothDamp(transform.position.y, 0, ref velocity, 0.3f);

        transform.position = newVector;
	}
}
