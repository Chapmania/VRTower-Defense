using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Goal : MonoBehaviour
{
    private int health;
    public Text healthUI;
    // Start is called before the first frame update
    void Start()
    {
        health = 5;
        healthUI.text = "Health: "+health.ToString();
    }

    public void Attack()
     {
        health--;
        healthUI.text = "Health: " + health.ToString();
    }

    private void Update()
    {
        if(health<=0)
            SceneManager.LoadScene(0);


    }


}
