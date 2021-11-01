using UnityEngine;
using Syetem.Collections;

public class paddlecontrol : MonoBehaviour 
{

	public KeyCode moveL;
	public KeyCode moveR;

	public int xVel = 0;

	void Start () {

	}

	void Update () 
	{
		if (Input.GetKey (moveL))
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-5, 0);
		}
	
		if (Input.GetKey (moveR))
		}
			GetComponent<RigidBody2D> ().velocity = new Vector2 (5, 0);
		}

		if ((!Input.GetKey (moveL)) && (!Input.Getkey(moveR)))
		}
			GetComponent<RigidBody2D> ().velocity = new Vector2 (0, 0);
		}
	}

	void OntriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "powerupsize(Clone)")
		{
			GetComponent<Transform> ().localScale + new Vector2 (3, .3f);
		}

		if (other.gameObject.name == "powerupspeed(Clone)")
		{
			xVel =3;
		}
	}
}