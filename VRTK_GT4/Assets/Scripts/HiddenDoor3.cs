namespace VRTK.Controllables.ArtificialBased {

	//using VRTK.Examples;
	//using VRTK.GrabAttachMechanics;
	//using VRTK.SecondaryControllerGrabActions;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public class HiddenDoor3 : MonoBehaviour {

		public GameObject leverControl;
		private float leverState;

		void Start () {

		}

		void Update () {

			leverState = leverControl.GetComponent<VRTK_ArtificialRotator>().GetNormalizedValue();
			deactivateDoor (leverState);

		}

		void deactivateDoor(float leverState) {

			if(leverState > 0.9){
                float position = transform.position.y;
                if (position > 0)
                {
                    transform.Translate(Vector3.down * Time.deltaTime);
                }
            }
		}
	}
}