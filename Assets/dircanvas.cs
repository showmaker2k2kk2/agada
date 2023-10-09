using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dircanvas : MonoBehaviour
{
    Transform cameratranform;
    Camera cam;

    void Start()
    {
        cameratranform = Camera.main.transform;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.LookAt(transform.position+ cameratranform.rotation * Vector3.forward, cameratranform.rotation * Vector3.up);
      
    }

}
