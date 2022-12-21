using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DurabilityManager : MonoBehaviour{

    public GameObject PlayerPrefab;
    public GameObject Spawn;
    public TextMesh durabilityText;
    public int lifes;
    public GameObject EndGameScreen;
    private GameObject Player;

    void Start()
    {
        Player = (GameObject)Instantiate(PlayerPrefab, Spawn.transform.position, Quaternion.identity);
    }
    void Update()
    {
        if(Player.GetComponent<CarMovement>().durability <= 0)
        {
            Destroy(Player);
            lifes--;
            if(lifes > 0)
            {
                StartCoroutine("SpawnCar");
            } else if(lifes <= 0)
            {
                Time.timeScale = 0;
                EndGameScreen.SetActive(true);
            }
        } 

        durabilityText.text = "Durability: " + Player.GetComponent<CarMovement>().durability + "/" + Player.GetComponent<CarMovement>().maxDurability;

    }

    IEnumerator SpawnCar()
    {
        Player = (GameObject)Instantiate(PlayerPrefab, Spawn.transform.position, Quaternion.identity);
        Player.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0.4f);
        Player.GetComponent<BoxCollider2D>().isTrigger = true;
        Player.tag = "Untouchable";
        yield return new WaitForSeconds(2);
        Player.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
        Player.GetComponent<BoxCollider2D>().isTrigger = false;
        Player.tag = "Player";
    }
}
