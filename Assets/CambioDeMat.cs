using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioDeMat : MonoBehaviour
{
    public Material[] mat;
    Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = mat[0];

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Golpe")
        {
            rend.sharedMaterial = mat[1];
        }
        else
        {
            rend.sharedMaterial = mat[2];
        }
    }
}
