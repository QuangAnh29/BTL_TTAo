using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light_sen : MonoBehaviour
{
    public Light my_L;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player") 
        {
            my_L.enabled = true;
        }
    }

}
