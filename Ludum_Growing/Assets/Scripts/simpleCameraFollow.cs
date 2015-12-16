using UnityEngine;
using System.Collections;

public class simpleCameraFollow : MonoBehaviour {

	     public Transform target;
 
     void Update ()
     {
         Vector3 position = transform.position;
         position.x = target.transform.position.x;
         position.y = 3f;
         transform.position =  position;
     }

	// Use this for initialization
	void Start () {
	
	}
	
}
