using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCharacterContoller : MonoBehaviour
{
    //  event �ܺο��� ȣ������ ���ϰ� ���´�.
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;

    public void CallMoveEvent(Vector2 direction)
    {
        //  ?. < �� ���� Null�� �ƴ� ��� �����Ѵ�.
        OnMoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }
    void Start()
    {

    }
}

//�߻�� ������ ���� ���̴�.
//public event Action OnAttackEvent;

//private float _timeSinceLastAttack = float.MaxValue;
//protected bool IsAttacking { get; set; }

//protected virtual void Update()
//{
//    HandleAttackDelay();
//}

//private void HandleAttackDelay()
//{
//    if (_timeSinceLastAttack <= 0.5f)
//    {
//        _timeSinceLastAttack += Time.deltaTime;
//    }
//    if (IsAttacking && _timeSinceLastAttack > 0.5f)
//    {
//        _timeSinceLastAttack = 0;
//        CallAttackEvent();
//    }
//}

//private void CallAttackEvent()
//{
//    OnAttackEvent?.Invoke();
//}

// �̵� �⺻ ���� �ڵ�
//[SerializeField] private float speed = 5f;
//// Start is called before the first frame update
//void Start()
//{

//}

//// Update is called once per frame
//void Update()
//{
//    float x = Input.GetAxisRaw("Horizontal");
//    float y = Input.GetAxisRaw("Vertical");

//    transform.position += new Vector3(x, y) * speed * Time.deltaTime;


//}