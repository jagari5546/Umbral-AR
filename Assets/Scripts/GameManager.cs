using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [SerializeField] private GameObject[] ModelsPanels;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private static GameManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    void Start()
    {
        foreach (var panel in ModelsPanels)
        {
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
