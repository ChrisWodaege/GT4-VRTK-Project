namespace VRTK.Controllables.ArtificialBased
{
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using VRTK.Controllables;
	using VRTK.Examples;

    public class FadeOutObject : MonoBehaviour
    {
        public GameObject SnapZone;
        private float alpha = 1;
        private Material mat;
        private bool onSnap;
        private float value;
        private bool isSnaped = false;

        void Update()
        {
            onSnap = SnapZone.GetComponent<VRTK_SnapDropZone>().ValidSnappableObjectIsHovering();

            if (Input.GetMouseButton(0) && onSnap)
            {
                isSnaped = true;
            }
      
            if (isSnaped)
            {
                SetVisibility();
            }
        }

        void SetVisibility()
        {
            value += 0.005f;
            alpha = Mathf.Lerp(1.0f, 0f, value);

            mat = GetComponent<Renderer>().material;
            Color currentColor = mat.color;
            currentColor.a = alpha;
            mat.color = currentColor;
        }

    }
}