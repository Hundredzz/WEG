using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Load : MonoBehaviour   
{
    
    public int what_load;
    public int Endgame;
    // Start is called before the first frame update
    public void LoadGame()
    {
        SceneManager.LoadScene(what_load);
    }

    // Update is called once per frame
    public void QuitGame()
    {
        Application.Quit();
    }
    private void OnTriggerEnter(Collider Hitmark)
    {

        if (Hitmark.gameObject.tag == "End")
        {
            SceneManager.LoadScene(Endgame);
        }
  
    }


}
