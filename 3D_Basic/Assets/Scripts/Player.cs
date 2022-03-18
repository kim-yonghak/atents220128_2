using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    /// 9시 45분까지 구현해보기(Input System 사용)
    /// WASD로 캐릭터 움직이기
    /// W : 전진
    /// S : 후진
    /// A : 좌회전
    /// D : 우회전
    /// 

    public float moveSpeed = 5.0f;
    public float spinSpeed = 360.0f;
    private float spinInput = 0.0f;
    private float moveInput = 0.0f;

    private void Update()
    {
        transform.Translate(Vector3.forward * moveInput * moveSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up, spinInput * spinSpeed * Time.deltaTime);
    }

    public void Move(InputAction.CallbackContext context)
    {        
        Vector2 input = context.ReadValue<Vector2>();
        spinInput = input.x;
        moveInput = input.y;
    }

}
