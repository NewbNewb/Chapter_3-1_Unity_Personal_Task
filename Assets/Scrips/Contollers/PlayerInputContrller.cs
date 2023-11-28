using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputContrller : TopDownCharacterContoller
{
    private Camera _camera;

    private void Awake()
    {
        _camera = Camera.main;
    }

    public void OnMove(InputValue value)
    {
        //Debug.Log("OnMove" + value.ToString());
        //  normalized > 대각선으로 움직이면 벨류값이 1+1이 되서 빠르게 움직인다.
        //  이것을 1로 고정 시키는 것이 노멀라이즈
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput); // MoveEvent에 묶여있는 동작을 모두 실행
    }
    public void OnLook(InputValue value)
    {
        // 마우스 포지션을 가저온다.
        Vector2 newAim = value.Get<Vector2>();
        //  카메라 기준 마우스 위치를 월드 포지션으로 지정
        Vector2 worldpos = _camera.ScreenToWorldPoint(newAim);
        // 내 캐릭터에서 마우스 까지 거리와 방향을 알 수 있다.
        newAim = (worldpos - (Vector2)transform.position).normalized;

        // 거기서 normalized 을 사용해 대각선 값을 1로 고정


        if (newAim.magnitude >= .9f)
        // 백터 값을 실수로 변경하는 작업
        {
            CallLookEvent(newAim);
        }
    }
    void Start()
    {

    }

    //무기 관련
    //public void OnFire(InputValue value)
    //{
    //    IsAttacking = value.isPressed;
    //}
}
