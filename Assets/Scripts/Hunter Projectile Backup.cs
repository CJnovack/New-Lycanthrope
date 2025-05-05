using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HunterProjectileBackup : MonoBehaviour
{
    public float speed = 30.0f;
    public GameObject Arrow;
    public Transform Hunter;
    public float ArrowFire;
    public float ArrowDelay;
    public PlayerControl player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player/Werewolf").GetComponent<PlayerControl>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
