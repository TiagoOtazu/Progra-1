using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] public GameObject winUI;
    [SerializeField] public GameObject looseUI;
    [SerializeField] public GameObject uI;
    [SerializeField] public GameObject mainMenu;
    [SerializeField] public Button startButton;
    [SerializeField] public Button resetButtonL;
    [SerializeField] public Button exitGameW;
    [SerializeField] public Button exitGameL;
    [SerializeField] public Button resetButtonW;
    [SerializeField] public Image lifeBar;
    [SerializeField] public GameObject character;
    
    // Update is called once per frame
    void Update()
    {
    }

    private void Awake()
    {
        winUI.gameObject.SetActive(false);
        looseUI.gameObject.SetActive(false);
        uI.gameObject.SetActive(false);
        winUI.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(true);
        startButton.onClick.AddListener(StartGame);
        resetButtonW.onClick.AddListener(ResetGame);
        resetButtonL.onClick.AddListener(ResetGame);
        exitGameL.onClick.AddListener(ExitGame);
        exitGameW.onClick.AddListener(ExitGame);
        LifeManager lifeManageScript = character.GetComponent<LifeManager>();
        lifeManageScript.looseEvent.AddListener(ShowLooseUI);
    }

    private void ExitGame()
    {
        Application.Quit();
    }

    private void StartGame()
    {
        winUI.gameObject.SetActive(false);
        looseUI.gameObject.SetActive(false);
        uI.gameObject.SetActive(true);
        winUI.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(false);
    }
    private void ResetGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void updateLifeBar(float currentlife)
        { 
            lifeBar.fillAmount = currentlife / 100;
        }
    private void ShowLooseUI()
    {
        winUI.gameObject.SetActive(false);
        looseUI.gameObject.SetActive(true);
        uI.gameObject.SetActive(false);
        winUI.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(false);
    }
}
