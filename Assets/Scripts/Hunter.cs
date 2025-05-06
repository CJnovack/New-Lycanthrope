using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hunter : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody2D hunterRb;
    private GameObject player;
    public GameObject projectilePrefab;
    public GameObject arrow;
    public Transform arrowSpawn;
    public float fireTime = 5.0f;
   // private float spawnTime = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        hunterRb = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player/Werewolf");
    }

    // Update is called once per frame
    void Update()
    {
        hunterRb.AddForce((player.transform.position - transform.position).normalized * speed);
    }
}
