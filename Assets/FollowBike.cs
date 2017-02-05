using UnityEngine;
using System.Collections;

public class FollowBike : MonoBehaviour {

    // Electric Bike By pier shaw 2014


    public GameObject target;
	private Vector3 vpos;
	private float speed;


	public void Start () {
		vpos = new Vector3(0,0,-10f);
		target.GetComponent<ConstantForce2D>().force = new Vector2(1,0);
		target.GetComponent<ConstantForce2D> ().torque = 100;
	}
	

	public void Update () {
	
		
		vpos.x = target.transform.position.x;
		vpos.y = target.transform.position.y;

		this.gameObject.transform.position = vpos;
      

        if (Input.GetKeyDown ("d")) {
			speed += 2;
			target.GetComponent<ConstantForce2D> ().force = new Vector2 (speed, 0);
		}

		if (Input.GetKeyDown ("a")) {
			speed -= 2;
			target.GetComponent<ConstantForce2D> ().force = new Vector2 (speed, 0);
		}


	}
}
