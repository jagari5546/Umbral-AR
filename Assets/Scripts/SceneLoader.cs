using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
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
    public void LoadMujerBaranda()
    {
        SceneManager.LoadScene("ModoARMujerBaranda");
        
    }
    public void LoadMomentos()
    {
        SceneManager.LoadScene("ModoARMomentos");
        
    }
    public void LoadBicicleta()
    {
        SceneManager.LoadScene("ModoARBicicleta");
        
    }
    
}
