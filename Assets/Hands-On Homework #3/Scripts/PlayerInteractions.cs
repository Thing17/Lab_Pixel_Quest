using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInteractions : MonoBehaviour
{
    public string sceneName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Coin":
                {
                    Destroy(collision.gameObject);
                    break;
                }
            case "Teleport":
                {
                    SceneManager.LoadScene(sceneName);
                    break;
                }
        }
    }
}
