using UnityEngine;
using System.Collections;

public class CivilCar : MonoBehaviour {

    public float crashDamage = 20f;
    public float civilCarSpeed = 5f;
    public int direction = -1;
    public int pointsPerCar;
    

    private Vector3 civilCarPosition;

    void Update()
    {
        this.gameObject.transform.Translate(new Vector3(0, direction, 0) * civilCarSpeed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D obj)
    {
        if(obj.gameObject.tag == "Player")
        {
            obj.gameObject.GetComponent<CarMovement>().durability -= crashDamage / 5;
        }
    }
    void OnTriggerEnter2D(Collider2D obj)
    {
        if(obj.gameObject.tag == "Player")
        {
            obj.gameObject.GetComponent<CarMovement>().durability -= crashDamage;
            Destroy(this.gameObject);
        } else if (obj.gameObject.tag == "UsuwaniePojazdow")
        {
            Destroy(this.gameObject);
            PointsManager.points += pointsPerCar;
        } 
        
    }
}