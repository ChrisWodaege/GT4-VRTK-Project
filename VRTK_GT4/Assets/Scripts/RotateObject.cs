namespace VRTK.Controllables.ArtificialBased {
	
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public class RotateObject : MonoBehaviour {

		public GameObject rotatorControl;
		protected float rotatorState;
	
		void Start () {
			Debug.Log (gameObject.name);
		}
		
	
		void Update () {
			rotatorState = rotatorControl.GetComponent<VRTK_ArtificialRotator>().GetValue();
			Debug.Log (rotatorState);
			rotateObject (rotatorState);
		}

		void rotateObject (float rotatorState){
			
			transform.eulerAngles = new Vector3 (0, rotatorState/4, 0);
		
		}
	}
}