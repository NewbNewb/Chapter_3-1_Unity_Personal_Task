using UnityEngine;

public class TopDownAimRotation : MonoBehaviour
{
    // 무기는 만들지 않을 것이다.
    //[SerializeField] private SpriteRenderer armRenderer;
    //[SerializeField] private Transform armPivot;

    [SerializeField] private SpriteRenderer characterRenderer;
    private TopDownCharacterContoller _controller;

    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterContoller>();
    }
    void Start()
    {
        _controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 newAimDirection)
    {
        RotateArm(newAimDirection);
    }

    private void RotateArm(Vector2 direction)
    {
        float rotz = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        characterRenderer.flipX = Mathf.Abs(rotz) > 90f;

        //무기 관련
        //armRenderer.flipY = Mathf.Abs(rotz) > 90f;
        //characterRenderer.flipX = armRenderer.flipY;
        //armPivot.rotation = Quaternion.Euler(0, 0, rotz);
    }
}
