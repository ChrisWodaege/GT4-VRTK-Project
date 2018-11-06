namespace VRTK.Controllables.ArtificialBased {

	using VRTK.Controllables.PhysicsBased;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public class MoveBigDoor : MonoBehaviour {

		public GameObject slider1;
		public GameObject slider2;
		private float currentValue;
		private float sliderState1;
		private float sliderState2;

		void Start () {
			
		}
		
	
		void Update () {
			currentValue = slider1.GetComponent<VRTK_PhysicsSlider>().GetValue();
			sliderState1 = slider1.GetComponent<VRTK_PhysicsSlider>().GetStepValue(currentValue);
		
			currentValue = slider2.GetComponent<VRTK_PhysicsSlider>().GetValue();
			sliderState2 = slider2.GetComponent<VRTK_PhysicsSlider>().GetStepValue(currentValue);

			Debug.Log("s1: " + sliderState1);
			Debug.Log("s2: " + sliderState2);
			if (sliderState1 == 3 && sliderState2 == 4) {

				MoveDoor ();
			}

		}

		void MoveDoor(){

			float position = transform.position.z;

			if (position > -2f) {
				transform.Translate (Vector3.back * Time.deltaTime);
			} 
		}
	}
}