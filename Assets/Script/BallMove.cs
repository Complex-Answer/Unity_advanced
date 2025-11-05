using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    [SerializeField] float moveSpeed = 3;

    //void BallAttack()
    //{
    //    transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    //}

    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
}
