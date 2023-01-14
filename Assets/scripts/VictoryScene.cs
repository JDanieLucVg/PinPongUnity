using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class VictoryScene : MonoBehaviour
{
    void Start()
    {
        Invoke("LoadinMenu", 2);
    }
    public void LoadinMenu(){
        SceneManager.LoadScene("Menu");
    }
}
