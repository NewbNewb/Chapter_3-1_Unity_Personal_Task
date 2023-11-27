using UnityEngine;

public class TopDownAimRotation : MonoBehaviour
{
    // ����� ������ ���� ���̴�.
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

        //���� ����
        //armRenderer.flipY = Mathf.Abs(rotz) > 90f;
        //characterRenderer.flipX = armRenderer.flipY;
        //armPivot.rotation = Quaternion.Euler(0, 0, rotz);
    }
}
