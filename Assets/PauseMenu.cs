using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused=false;

    public GameObject pauseMenuUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(gameIsPaused)
            {
                Resume();
            }else{
                Paused();
            }
            
        }
       
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale=1f;
        gameIsPaused=false;
    }
    public void Paused()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale=0f;
        gameIsPaused=true;
    }
    public void Menuuu()
    {
        SceneManager.LoadScene("Menu");
    }


}
