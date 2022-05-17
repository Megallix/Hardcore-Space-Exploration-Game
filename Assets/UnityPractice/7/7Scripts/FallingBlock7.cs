using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBlock7 : MonoBehaviour
{
    float speed = 7;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
}
