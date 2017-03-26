using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToggle : MonoBehaviour {

    void Start()
    {
    }
    void OnMouseDown()
    {
            if (GameInfo.gameState == 1)
            {
                Application.LoadLevel(Application.loadedLevel + 1);
            }
            if (GameInfo.gameState == 2)
            {
                Application.LoadLevel(Application.loadedLevel + 2);
            }
    }
}
