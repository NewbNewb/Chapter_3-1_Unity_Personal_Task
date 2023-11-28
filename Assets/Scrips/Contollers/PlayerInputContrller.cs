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
        //  normalized > �밢������ �����̸� �������� 1+1�� �Ǽ� ������ �����δ�.
        //  �̰��� 1�� ���� ��Ű�� ���� ��ֶ�����
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput); // MoveEvent�� �����ִ� ������ ��� ����
    }
    public void OnLook(InputValue value)
    {
        // ���콺 �������� �����´�.
        Vector2 newAim = value.Get<Vector2>();
        //  ī�޶� ���� ���콺 ��ġ�� ���� ���������� ����
        Vector2 worldpos = _camera.ScreenToWorldPoint(newAim);
        // �� ĳ���Ϳ��� ���콺 ���� �Ÿ��� ������ �� �� �ִ�.
        newAim = (worldpos - (Vector2)transform.position).normalized;

        // �ű⼭ normalized �� ����� �밢�� ���� 1�� ����


        if (newAim.magnitude >= .9f)
        // ���� ���� �Ǽ��� �����ϴ� �۾�
        {
            CallLookEvent(newAim);
        }
    }
    void Start()
    {

    }

    //���� ����
    //public void OnFire(InputValue value)
    //{
    //    IsAttacking = value.isPressed;
    //}
}
