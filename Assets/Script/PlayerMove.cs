using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    Vector3 _move;
    Rigidbody rb;
    public void OnMove(InputAction.CallbackContext ctx)
    {
        Vector2 dic = ctx.ReadValue<Vector2>();
        _move = new Vector3(dic.x,0,dic.y);
    }



    private void FixedUpdate()
    {
        if(_move != Vector3.zero)
        {
          transform.rotation = Quaternion.LookRotation(_move);
         transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
           
        }

        



    }



}
