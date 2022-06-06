using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;
    public float horizontalInput;
    private int count;
    public Text countText;
    public Text winText;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        setCountText();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pickup"))
        {
            AudioSource source = GetComponent<AudioSource>();
            source.Play();
            other.gameObject.SetActive(false);
            count = count + 1;
            setCountText();
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        horizontalInput = Input.GetAxis("Horizontal");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * 1);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.left, verticalInput * rotationSpeed * Time.deltaTime);

        transform.Rotate(Vector3.back, horizontalInput * rotationSpeed * Time.deltaTime);
    }

    void setCountText()
    {
        countText.text = "Count : " + count.ToString();
        if (count >= 20)
        {
            winText.text = "You Win!";
        }
    }
}
