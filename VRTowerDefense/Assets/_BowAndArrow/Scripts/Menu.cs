using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public enum button { play, exit};
    public GameObject menu;
    public button b;


    public void Press()
    {
        Debug.Log("hit");
        switch (b)
        {
            case (button.play):
                GameManager.play = true;
                menu.SetActive(false);
                break;
            case (button.exit):
                Application.Quit();
                break;
        }
    }
}
