using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public GameObject cam;
    public float parallax;
    float startPosX;

    void Start()
    {
        startPosX = transform.position.x;
    }

    
    void Update()
    {
        float distX = (cam.transform.position.x * (1 - parallax));
        transform.position = new Vector3(startPosX + distX, transform.position.y, transform.position.z);
    }
}
