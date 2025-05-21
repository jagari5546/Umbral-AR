using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadARCamera()
    {
        SceneManager.LoadScene("ModoAR");
    }
    public void LoadMap()
    {
        SceneManager.LoadScene("MapaInteractivo");
    }

    public void CloseApplication()
    {
        Application.Quit();
    }

    private void loadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
