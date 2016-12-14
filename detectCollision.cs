using UnityEngine;
using System.Collections;

public class detectCollision : MonoBehaviour {

    public AudioSource catAudio;

    public void OnCollisionEnter(Collision collision)
    {     
        //Avoid making the sound at the start, as the objects were "dropping" into their default posiiton on the ground   
        if (collision.gameObject.name.Equals("EarthLow(Clone)"))
        {
                  
            if (catAudio != null)
            {              
                catAudio.Play();
            }

            Destroy(collision.gameObject);
        }       
    }
}
