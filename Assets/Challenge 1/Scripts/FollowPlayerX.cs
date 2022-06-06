using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    void Update()
    {
        //Camera follows planes every move.
        transform.position = plane.transform.position;
        transform.rotation = plane.transform.rotation;

    }
}
