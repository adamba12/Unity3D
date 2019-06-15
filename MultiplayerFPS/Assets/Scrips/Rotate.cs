using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour
{

    public float rotSpeed = 0f;

    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * rotSpeed);
    }
}