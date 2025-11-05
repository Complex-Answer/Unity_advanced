using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameOverUI : MonoBehaviour
{
    [SerializeField] PlayerHp player;
    [SerializeField] GameObject gameOverUI;
    private void Awake()
    {
        gameOverUI.SetActive(false);
    }
    private void Update()
    {
        if (player.playerHp == 0)
        {
            gameOverUI.SetActive(true);
          Time.timeScale = 0;

        }
    }
}
