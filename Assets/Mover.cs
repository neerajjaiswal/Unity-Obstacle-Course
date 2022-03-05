using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField] float x = 0;
    [SerializeField] float y = 0.01F;
    [SerializeField] float z = 0;

    // Start is called before the first frame update
    void Start()
    {
        // transform.Translate(1,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal"),y,z);
    }
}
