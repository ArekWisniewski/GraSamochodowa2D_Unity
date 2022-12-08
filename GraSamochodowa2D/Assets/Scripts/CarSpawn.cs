using UnityEngine;
using System.Collections;

public class CarSpawn : MonoBehaviour {

    public float carSpawnDelay = 1f;
    public GameObject Civil;

    private float[] lanesArray;

    private float spawnDelay;

    void Start()
    {
        lanesArray = new float[4];
        lanesArray[0] = -2.16f;
        lanesArray[1] = -0.76f;
        lanesArray[2] = 0.76f;
        lanesArray[3] = 2.16f;
        spawnDelay = carSpawnDelay;
    }

    void Update()
    {
        spawnDelay -= Time.deltaTime;
        if(spawnDelay<=0)
        {
            spawnCar();
            spawnDelay = carSpawnDelay;
        }
    }

    void spawnCar()
    {
        int lane = Random.Range(0, 4);
        if (lane == 0 || lane == 1)
        {
            GameObject car = (GameObject)Instantiate(Civil, new Vector3(lanesArray[lane], 6f, 0), Quaternion.Euler(new Vector3(0, 0, 180)));
            car.GetComponent<CivilCar>().direction = 1;
            car.GetComponent<CivilCar>().civilCarSpeed = 12f;
        }
        if (lane == 2 || lane == 3)
        {
            Instantiate(Civil, new Vector3(lanesArray[lane], 6f, 0), Quaternion.identity);
        }
    }

}