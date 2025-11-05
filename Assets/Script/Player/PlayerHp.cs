using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerHp : MonoBehaviour
{
    [SerializeField] public float playerHp = 3;

    private List<IPlayerHpChangeObserver> Observers = new List<IPlayerHpChangeObserver>();

    public void AddObserver(IPlayerHpChangeObserver observer) => Observers.Add(observer);
    public void RemoveObserver(IPlayerHpChangeObserver observer) => Observers.Remove(observer);

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 7)
        {
           
            if (playerHp <= 0)
            {
                playerHp = 0;
            }
            playerHp--;
            HpUpdate();
            Debug.Log("플레이어 체력 감소: " + playerHp);
        }
    }
    private void Start()
    {
        HpUpdate();
    }
    void PlayerOver()
    {
        if (playerHp <= 0)
        {
            playerHp = 0;
            Debug.Log("플레이어 체력이 전부 소진됐습니다");
            Destroy(gameObject);
           
        }
    }
    private void Update()
    {
        PlayerOver();
    }

    private void HpUpdate()
    {
        foreach (var observer in Observers)
        {
            observer.OnPlayerHpChange(playerHp);
        }
    }
}