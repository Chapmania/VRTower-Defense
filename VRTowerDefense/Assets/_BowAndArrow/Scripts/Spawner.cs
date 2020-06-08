using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject enemy;
    private float timer;
    private void Start()
    {
        timer = Random.Range(2,5);
    }
    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0) 
        {
            timer = Random.Range(5, 20);
            Instantiate(enemy, transform.position, transform.rotation);

        }

    }
}
