using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [SerializeField] private GameObject[] ModelsPanels;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

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

    
}
