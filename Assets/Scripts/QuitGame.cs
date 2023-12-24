using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        QuitGame();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
