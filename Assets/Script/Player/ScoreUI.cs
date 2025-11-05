using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textMeshPro;
    [SerializeField] PlayerHp player;

    void Update()
    {
        if(player.playerHp > 0)
        {
        textMeshPro.text = "Score : " +Time.time.ToString("F1");

        }
        else
        {
            return;
        }

    }
}
