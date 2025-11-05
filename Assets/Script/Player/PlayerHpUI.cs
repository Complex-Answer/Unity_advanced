using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHpUI : MonoBehaviour, IPlayerHpChangeObserver
{
    [SerializeField]TextMeshProUGUI textMeshPro;
    [SerializeField] PlayerHp player;
    public void OnPlayerHpChange(float hp)
    {
        textMeshPro.text = $"Hp : {hp}";
    }

    void Awake()
    {
        player.AddObserver(this);
    }


    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
    }


    void Update()
    {
        
    }
}
