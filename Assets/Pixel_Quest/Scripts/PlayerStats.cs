using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    private int coinCounter = 0;
    private int coinsInLevel = 0;
    public int _health = 3;
    public int _maxHealth = 3;

    public Transform RespawnPoint;

    private PlayerUIController _playerUIController;

    private void Start()
    {
        coinsInLevel = GameObject.Find("Coins").transform.childCount;
        _playerUIController = GetComponent<PlayerUIController>();
        _playerUIController.UpdateHealth(_health, _maxHealth);
        _playerUIController.UpdateCoinText(coinCounter + "/" + coinsInLevel);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Finish":
                {
                    string nextLevel = collision.transform.GetComponent<LevelGoal>().nextLevel;
                    SceneManager.LoadScene(nextLevel);
                    break;
                }
            case "Death":
                {
                    _health--;
                    _playerUIController.UpdateHealth(_health, _maxHealth);

                    if (_health <= 0)
                    {
                        string thisLevel = SceneManager.GetActiveScene().name;
                        SceneManager.LoadScene(thisLevel);
                    }
                    else
                    {
                        transform.position = RespawnPoint.position;
                    }
                    break;
                }
            case "Coin":
                {
                    coinCounter++;
                    _playerUIController.UpdateCoinText(coinCounter + "/" + coinsInLevel);
                    Destroy(collision.gameObject);
                    break;
                }
            case "Health":
                {
                    if (_health < 3)
                    {
                        _health++;
                        _playerUIController.UpdateHealth(_health, _maxHealth);
                        Destroy(collision.gameObject);
                    }
                    break;
                }
            case "Respawn":
                {
                    RespawnPoint.position = collision.transform.Find("Point").position;
                    break;
                }
        }
    }
}
