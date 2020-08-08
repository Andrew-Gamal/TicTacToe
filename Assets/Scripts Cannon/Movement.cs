using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speedH = 2.0f;
    [SerializeField] private float speedV = 2.0f;
    private float yAxsis = 0.0f;
    private float pitch = 0.0f;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        yAxsis += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, yAxsis, 0.0f);

    }
}
