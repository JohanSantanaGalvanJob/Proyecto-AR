using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadCreditsScene : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void loadScene(string pSceneName) {
        Debug.Log("BOTON PULSADO");
        SceneManager.LoadScene(pSceneName);
    }
}
