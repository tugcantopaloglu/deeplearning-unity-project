using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{
    [SerializeField] GameObject[] menuButtons;
    [SerializeField] string[] menuItemList;
    [SerializeField] GameObject musicSelectScreen;
    void Start()
    {
        SetMenuButtons();
    }
    void SetMenuButtons()
    {
        for (int i = 0; i < menuButtons.Length; i++)
        {
            TextMeshProUGUI buttonText = menuButtons[i].GetComponentInChildren<TextMeshProUGUI>();
            buttonText.text = menuItemList[i];
        }
    }

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame(){
        Application.Quit();
        Debug.Log("Game Quited");
    }

    public void OpenMusicSelect(){
        musicSelectScreen.SetActive(true);
    }

    public void CloseMusicSelect(){
        musicSelectScreen.SetActive(false);
    }
}
