namespace VRTK.Controllables.ArtificialBased {

	//using VRTK.Examples;
	//using VRTK.GrabAttachMechanics;
	//using VRTK.SecondaryControllerGrabActions;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public class HiddenDoor1 : MonoBehaviour {

		public GameObject leverControl;
		private float leverState;

		void Start () {

			Debug.Log (gameObject.name);
			
		}

		void Update () {

			leverState = leverControl.GetComponent<VRTK_ArtificialRotator>().GetNormalizedValue();
			deactivateDoor (leverState);

		}

		void deactivateDoor(float leverState) {

			if(leverState > 0.9){
				gameObject.SetActive (false);	
			}
		}
	}
}