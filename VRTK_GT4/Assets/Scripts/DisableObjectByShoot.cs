namespace VRTK.Controllables.PhysicsBased {
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class DisableObjectByShoot : MonoBehaviour {
        public GameObject pushDownButton;
        float isPushed;
        // Use this for initialization


        // Update is called once per frame
        void Update() {
            isPushed = pushDownButton.GetComponent<VRTK_PhysicsPusher>().GetNormalizedValue();
     
            if (isPushed > 0.7f)
            {
                gameObject.SetActive(false);
            }
    }
    }
}