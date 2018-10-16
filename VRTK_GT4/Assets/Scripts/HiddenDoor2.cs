﻿namespace VRTK.Controllables.ArtificialBased {
	
	using VRTK.GrabAttachMechanics;
	using VRTK.SecondaryControllerGrabActions;
	using VRTK.Controllables.PhysicsBased;
	using System.Collections;
	using System.Collections.Generic;
	using VRTK.Examples;
	using UnityEngine;

	public class HiddenDoor2 : MonoBehaviour {

		public GameObject sliderControl;
		protected float sliderState;
		protected float currentValue;

		void Start () {
			
			Debug.Log (gameObject.name);
			
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