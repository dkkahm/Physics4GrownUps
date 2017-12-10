using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallingManager : MonoBehaviour {
    public void OnBackClicked()
    {
        SceneManager.LoadScene("scLobby");
    }

    private void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                SceneManager.LoadScene("scLobby");
            }
        }
    }
}
