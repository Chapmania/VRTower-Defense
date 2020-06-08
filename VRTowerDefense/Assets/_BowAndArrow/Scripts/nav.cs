using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nav : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] points;
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Enemy>().turns > 0)
            collision.gameObject.transform.LookAt(points[0].transform);
        else
            collision.gameObject.transform.LookAt(points[Random.Range(0,points.Length)].transform);
        collision.gameObject.GetComponent<Enemy>().turns++;

    }
}
