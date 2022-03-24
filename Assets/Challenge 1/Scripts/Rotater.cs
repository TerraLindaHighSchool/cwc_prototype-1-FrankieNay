using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour
{
    private Vector3 _rotation;
    [SerializeField] private float _speed;
 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) _rotation = Vector3.forward;
        else if (Input.GetKey(KeyCode.DownArrow)) _rotation = Vector3.back;
        else _rotation = Vector3.forward * 2;

        transform.Rotate(_rotation * _speed * Time.deltaTime);
    }
}
