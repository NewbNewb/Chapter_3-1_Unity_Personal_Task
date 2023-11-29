using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class JoinWorld : MonoBehaviour
{
    [SerializeField] private GameObject _NameLengthError;
    [SerializeField] private InputField _InputText;
    public static string _name { get; set; }

    public void MainSceneStart()
    {
        _name = _InputText.text;

        if (_name.Length >= 2 && _name.Length <= 10)
        {
            SceneManager.LoadScene("MainScene");
        }
        else
        {
            nameLengthError();
        }
    }
    private void nameLengthError()
    {
        _NameLengthError.SetActive(true);
    }
}
