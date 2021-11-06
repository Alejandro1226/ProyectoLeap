using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frenar : MonoBehaviour
{
    public float limiteYinferior = 0.011f;
    public float limiteYsuperior = 0.031f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y>limiteYsuperior)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, limiteYsuperior, gameObject.transform.position.z);
        }

        if (gameObject.transform.position.y < limiteYinferior)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, limiteYinferior, gameObject.transform.position.z);
        }

    }
}
