using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;

public class BallUpSpawner : MonoBehaviour
{

    [SerializeField] GameObject spawnPrefab;
    [SerializeField] Transform targetPlayer;
  
    private WaitForSeconds spawnDelay;
    
    


    private void Start()
    {
        //spawnDelay = new WaitForSeconds(Random.Range(0.5f, 1f));
        //StartCoroutine(Spawner());
        InvokeRepeating(nameof(Spawner), 0.5f, 2);
        //0.5초부터 2초마다 반복해서 다른 스포너와 번갈아가면서 소환
    }

    void Spawner()
    {
        Vector3 dir = targetPlayer.position;
        //인스턴티에이트를 랜덤 범위내에서 소환시킴
        float a = Random.Range(-4.5f, 4.4f);
            Instantiate(spawnPrefab, new Vector3(a, 0.5f, 4.3f), Quaternion.LookRotation(dir));
        
    }
    //IEnumerator Spawner()
    //{
    //    Vector3 dir = targetPlayer.position;
    //    while (true)
    //    {
    //        float a = Random.Range(-4.5f, 4.4f);
    //        yield return spawnDelay;
    //        Instantiate(spawnPrefab, new Vector3(a, 0.5f, 4.3f), Quaternion.LookRotation(dir));
    //        //Instantiate(spawnPrefab, new Vector3(a, 0.5f, -4.3f), Quaternion.LookRotation(dir));
    //        //Instantiate(spawnPrefab, new Vector3(4.3f, 0.5f, a), Quaternion.LookRotation(dir));
    //        //Instantiate(spawnPrefab, new Vector3(-4.3f, 0.5f,a), Quaternion.LookRotation(dir));

    //    }
    //}
    //인보크 처리가 좋을것 같아 코루틴은 주석으로 작성됨
}
