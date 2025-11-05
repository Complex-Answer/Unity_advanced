using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallUpMove : MonoBehaviour
{
    [SerializeField] float movePower = 175;
    Rigidbody rig;
    
    private void Start()
    {
        rig = GetComponent<Rigidbody>();
        
    }

   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            rig.useGravity = true;
            Destroy(gameObject, 3);
        }
        else if (collision.collider)
        {
            //벽이나 플레이어에게 부딪히면 중력 활성화
            rig.useGravity = true;
            this.gameObject.layer = 0;
            //후 3초뒤에 게임오브젝트 제거
            Destroy(gameObject, 3);
        }
    }

  

    private void FixedUpdate()
    {

        //중력이 적용됐을 때 움직이지 않게 하기 위해 예외처리
        if (rig.useGravity != true)
        {
         Vector3 moveDir =(Vector3.forward * movePower * Time.deltaTime);
            rig.velocity = moveDir;

        }
       
    }
}
