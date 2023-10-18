using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public float rotationSpeed = 50.0f;

    public float scaleSpeed = 0.1f;
    public float maxScale = 2.0f;

    private bool isSpacePressed = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(-Vector3.up * rotationSpeed * Time.deltaTime);
        }


        /// increaase and decrease on pressing space bar cube szie

        if (Input.GetKey(KeyCode.Space))
        {
            if (transform.localScale.x < maxScale)
            {
                isSpacePressed = true;
                transform.localScale += Vector3.one * scaleSpeed * Time.deltaTime;
            }
        }
        else if (isSpacePressed)
        {
            isSpacePressed = false;
        }
    }
}