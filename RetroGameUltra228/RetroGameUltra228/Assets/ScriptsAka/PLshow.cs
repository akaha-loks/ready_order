using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLshow : MonoBehaviour
{
    [SerializeField] private GameObject pl;

    private void Update()
    {
        transform.position = new Vector3(pl.transform.position.x, transform.position.y, transform.position.z);
    }
}
