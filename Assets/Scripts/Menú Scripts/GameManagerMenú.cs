using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerMenú : MonoBehaviour
{
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) == true)
        {
            SceneManager.LoadScene("Game");
        }
    }
}
