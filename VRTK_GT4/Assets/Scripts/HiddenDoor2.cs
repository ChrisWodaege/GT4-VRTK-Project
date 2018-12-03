namespace VRTK.Controllables.ArtificialBased {

	//using VRTK.Examples;
	//using VRTK.GrabAttachMechanics;
	//using VRTK.SecondaryControllerGrabActions;
	using VRTK.Controllables.PhysicsBased;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public class HiddenDoor2 : MonoBehaviour {

		public GameObject sliderControl;
		private float sliderState;
		private float currentValue;

		void Start () {

			
		}

		void Update () {

			currentValue = sliderControl.GetComponent<VRTK_PhysicsSlider>().GetValue();
			sliderState = sliderControl.GetComponent<VRTK_PhysicsSlider>().GetStepValue(currentValue);
		
			moveDoor (sliderState);

		}

		void moveDoor(float sliderState) {

			transform.position = new Vector3(transform.position.x, sliderState , transform.position.z);

		}

	}
}