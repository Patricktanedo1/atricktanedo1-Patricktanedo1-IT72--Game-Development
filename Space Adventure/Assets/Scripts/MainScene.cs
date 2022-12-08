using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScene : MonoBehaviour
{
  public void loadNextScene(){
    SceneManager.LoadScene("SampleScene");
  }

  public void QuitGame()
{   
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #endif
    Application.Quit();
}
}
