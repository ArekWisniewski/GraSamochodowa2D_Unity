using UnityEngine;
using System.Collections;

public class CarMovement : MonoBehaviour {

    public float carHorizontalSpeed = 2f;
    private Vector3 carPosition;

    public float maxDurability = 100f;
    public float durability;


    void Start()
    {
        carPosition = this.gameObject.transform.position;
        durability = maxDurability;
    }

    void Update()
    {
        carPosition.x += Input.GetAxis("Horizontal") * carHorizontalSpeed * Time.deltaTime;
        carPosition.x = Mathf.Clamp(carPosition.x, -2.41f, 2.41f);
        this.gameObject.transform.position = carPosition;
    }

}