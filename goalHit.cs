using UnityEngine;
using System.Collections;

public class goalHit : MonoBehaviour
{

    public AudioSource goalAudio;

    void OnTriggerExit(Collider collider)
    {

        if (goalAudio != null)
        {
            goalAudio.Play();
        }
       Destroy(collider.gameObject);      
    }
}