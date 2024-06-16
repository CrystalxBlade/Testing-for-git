using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float steerSpeed, moveSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float steer = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float move = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Translate(0, move, 0);
        transform.Rotate(0, 0, -steer);
    }
}
