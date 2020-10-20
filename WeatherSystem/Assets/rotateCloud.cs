using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateCloud : MonoBehaviour
{
    public float MovementSpeed=1;
    public float radius = 400;
    public float timeRotate;
    public float circumference;
    // Start is called before the first frame update
    void Start()
    {
        circumference = 2 * radius * Mathf.PI;
        timeRotate = circumference / MovementSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(Vector3.forward * 360*Time.deltaTime/ timeRotate);
    }
}
