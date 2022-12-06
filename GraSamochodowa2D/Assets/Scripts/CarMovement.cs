using UnityEngine;
using System.Collections;

public class CarMovement : MonoBehaviour {

    public float carHorizontalSpeed = 2f;
    private Vector3 carPosition;


    void Start()
    {
        carPosition = this.gameObject.transform.position;
    }

    void Update()
    {
        carPosition.x += Input.GetAxis("Horizontal") * carHorizontalSpeed * Time.deltaTime;
        carPosition.x = Mathf.Clamp(carPosition.x, -2.41f, 2.41f);
        this.gameObject.transform.position = carPosition;
    }

}