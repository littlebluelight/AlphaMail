using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    public GameObject[] particles;
    public bool groundPuff;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameObject.GetComponent<PlayerController>().isGrounded && !groundPuff) {
            groundPuff = true;
        }

        if (gameObject.GetComponent<PlayerController>().isGrounded && groundPuff)
        {
            foreach (GameObject system in particles)
            {
                Instantiate(system, transform.position, system.transform.rotation);
            }
            groundPuff = false;
        }
    }
}
