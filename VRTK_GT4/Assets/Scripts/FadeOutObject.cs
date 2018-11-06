namespace VRTK.Controllables.ArtificialBased
{
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using VRTK.Controllables;
	using VRTK.Examples;

    public class FadeOutObject : MonoBehaviour
    {
        public GameObject sliderControl;

        private float switchstate;
  
        private Material mat;

     
        void Update()
        {
            SetVisibility();

        }

        void SetVisibility()
        {
            switchstate = sliderControl.GetComponent<VRTK_ArtificialRotator>().GetNormalizedValue();

            mat = GetComponent<Renderer>().material;
            Color currentColor = mat.color;
            currentColor.a = switchstate;
            mat.color = currentColor;


        }

    }
}