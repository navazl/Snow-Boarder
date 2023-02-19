using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem touchEffect;

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Ground" ){

            touchEffect.Play();
        }
    }

    private void OnCollisionExit2D(Collision2D other) {
        if (other.gameObject.tag == "Ground" ){
            touchEffect.Stop();
        }
    }
}
