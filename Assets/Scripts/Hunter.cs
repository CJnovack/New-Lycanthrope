using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hunter : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody2D hunterRb;
    private GameObject player;
    public GameObject projectilePrefab;
    public Transform firePoint;
    public float fireRate = 2.0f;
    private float fireCoolDown;
   // private float spawnTime = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        hunterRb = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player/Werewolf");
        Vector2 direction = (player.transform.position - transform.position).normalized;
        GetComponent<Rigidbody2D>().velocity = direction * speed;
        transform.up = direction;
    }

    // Update is called once per frame
    void Update()
    {
        hunterRb.AddForce((player.transform.position - transform.position).normalized * speed);
        fireCoolDown -= Time.deltaTime;
        if (fireCoolDown <= 0f)
        {
            ShootAtPlayer();
            fireCoolDown = fireRate;
        }
    }
    void ShootAtPlayer()
    {
        GameObject projectile = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);
        Vector2 direction = (player.transform.position - firePoint.position).normalized;
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = direction * 10f;
        }
    }
}
