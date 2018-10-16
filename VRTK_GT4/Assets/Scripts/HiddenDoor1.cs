namespace VRTK.Controllables.ArtificialBased {
	
	using VRTK.GrabAttachMechanics;
	using VRTK.SecondaryControllerGrabActions;
	using System.Collections;
	using System.Collections.Generic;
	using VRTK.Examples;
	using UnityEngine;

	public class HiddenDoor1 : MonoBehaviour {

		public GameObject leverControl;
		protected float leverState;

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