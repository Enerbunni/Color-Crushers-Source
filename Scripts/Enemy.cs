using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public int max, min;
    private float spawnX;
    public string color;

    void Start()
    {
        spawnX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position =new Vector3(spawnX + Mathf.PingPong(Time.time*2,max-min)+min, transform.position.y, transform.position.z);
    }

    public string getColor()
    {
        return color;
    } 
}
