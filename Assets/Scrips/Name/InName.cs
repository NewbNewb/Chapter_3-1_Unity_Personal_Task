using UnityEngine;
using UnityEngine.UI;

public class InName : MonoBehaviour
{
    [SerializeField] private Text _name;

    private void Awake()
    {
        _name.text = JoinWorld._name;
    }
}
