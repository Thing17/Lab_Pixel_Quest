using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public string nextLevel = "GeoLevel_2";

    private int CoinCounter = 0;
    private int Health = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Finish":
                {
                    SceneManager.LoadScene(nextLevel);
                    break;
                }
            case "Death":
                {
                    string thisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thisLevel);
                    break;
                }
            case "Coin":
                {
                    CoinCounter++;
                    Destroy(collision.gameObject);
                    break;
                }
            case "Health":
                {
                    Health++;
                    Destroy(collision.gameObject);
                    break;
                }
        }
    }
}
