using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SA {
    public class Helper : MonoBehaviour {
        [Range(0,1)] public float vertical;


        Animator anim;
        public string animName;
        public bool playAnim;


        // Start is called before the first frame update
        void Start() {
            anim = GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update() {

            if (playAnim) {
                playAnim = false;
                vertical = 0;
                anim.CrossFade(animName, 0.2f);
            }

            anim.SetFloat("vertical", vertical);

            
        }
    }
}
