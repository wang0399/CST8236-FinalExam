using UnityEngine;
using System.Collections;

public class earthCollisionDetection : MonoBehaviour {

    public void OnCollisionEnter(Collision collision)
    {
        
            // Check to see if the object has audio source
            AudioSource thisObjectAudio = collision.gameObject.GetComponent<AudioSource>();

            if (thisObjectAudio != null)
            {
                if (thisObjectAudio.isPlaying)
                    thisObjectAudio.Stop();

                thisObjectAudio.Play();
            }

            Destroy(this.gameObject);
        
    }
}
