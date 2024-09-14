using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainSceneUIManager : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject restartPanel;

    public static mainSceneUIManager Instance { set; get; }

    
    // Start is called before the first frame update
    private void Start()
    {
        Instance =this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void pauseBtnClicked()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void resumeBtnClicked()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void restartBtnClicked()
    {
        SceneManager.LoadScene(0);
    }

    public void gameOver()
    {
        restartPanel.SetActive(true);
    }
}
