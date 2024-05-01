using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public int sceneToLoad;
    // Start is called before the first frame update
   public void StartGame()
    {
        SceneManager.LoadScene(sceneToLoad);//Scene to load
        Debug.Log("New Scene Loaded!");
    }

   public void QuitGame()
   {
        Application.Quit();
        Debug.Log("Quit Game!");
   }
}
