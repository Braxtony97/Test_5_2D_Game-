using UnityEngine;
using UnityEngine.SceneManagement;

public class BootstrapEntryPoint : MonoBehaviour
{
    private void Start()
    {
        SceneManager.LoadScene("GamePlayScene");
    }
}
