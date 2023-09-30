using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public int lvlUnlock = 0;
    public Button[] buttons = new Button[16];
    public GameObject[] locks = new GameObject[16];
    
    void Start()
    {
        //locks = GameObject.FindGameObjectsWithTag("Locks");
        lvlUnlock = PlayerPrefs.GetInt("levels", 1);
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }
        for (int i = 0; i < lvlUnlock; i++)
        {
            buttons[i].interactable = true;
        }
        for (int i = 0; i < lvlUnlock; i++)
        {
            locks[i].SetActive(false);
        }

    }


    public void Playgame()
    {
        SceneManager.LoadScene(18);
    }

    public void GoMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ChooseLvl(int lvls)
    {
        SceneManager.LoadScene(lvls);
    }
    public void Resset()
    {
        PlayerPrefs.DeleteKey("levels");
    }

}
