using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private float WaitTime = 1f;
    [SerializeField] private GameObject MomentosIcon;
    [SerializeField] private GameObject MujerBarandaIcon;
    [SerializeField] private GameObject LaEncomiendaIcon;
    [SerializeField] private GameObject ExitButton;
    [SerializeField] private GameObject Momentos;
    [SerializeField] private GameObject MujerBaranda;
    [SerializeField] private GameObject LaEncomienda;
    [SerializeField] private GameObject PanelDesplegable;
    [SerializeField] private Animator PanelDesplegableAnimator;
    
    public void CerrarPanelDesplegable()
    {
        PanelDesplegableAnimator.SetTrigger("Close");
        PanelDesplegableAnimator.ResetTrigger("Open");
        StartCoroutine(EsperarUnSegundo());
    }

    IEnumerator EsperarUnSegundo()
    {
        yield return new WaitForSeconds(WaitTime); 
        Debug.Log("funciones despues de esperar");
        MomentosIcon.SetActive(true);
        MujerBarandaIcon.SetActive(true);
        LaEncomiendaIcon.SetActive(true);
        ExitButton.SetActive(true);
        MujerBaranda.SetActive(false);
        LaEncomienda.SetActive(false);
        Momentos.SetActive(false);
        PanelDesplegable.SetActive(false);
    }

    
}
