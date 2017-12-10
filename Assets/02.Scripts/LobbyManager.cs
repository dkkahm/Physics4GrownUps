using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LobbyManager : MonoBehaviour {
    public void OnFallingClicked()
    {
        SceneManager.LoadScene("scFalling");
    }
   
    public void OnProjectileClicked()
    {
        SceneManager.LoadScene("scProjectile");
    }

    private void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();
            }
        }
    }
}
