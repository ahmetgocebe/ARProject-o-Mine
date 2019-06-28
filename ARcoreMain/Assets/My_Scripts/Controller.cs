using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.Networking;
namespace GoogleARCore.Examples.CloudAnchors {

    public class Controller : NetworkBehaviour
    {

        public float speed;
      
        void FixedUpdate()
        {
            if (isLocalPlayer)
            {

                GetComponent<Animator>().SetBool("Punch", CrossPlatformInputManager.GetButtonDown("Jump"));
                
                GetComponent<Animator>().SetFloat("Walk", CrossPlatformInputManager.GetAxis("Horizontal"));
                transform.Translate(new Vector3(0, 0, GetComponent<Animator>().GetFloat("Walk") * Time.deltaTime * speed));
               
                GetComponent<Animator>().SetBool("Kick", CrossPlatformInputManager.GetButtonDown("Fire1"));
              
            }
        }
        private IEnumerator OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "attack")
            {
                GetComponent<AudioSource>().Play();
                GetComponent<HealthBar>().Damage();
                GetComponent<Animator>().SetTrigger("hit");
                Debug.Log("attacked");
                yield return new WaitForSeconds(2);

            }


            Debug.Log("Nothing but collision");
        }

    }

}