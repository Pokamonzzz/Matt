using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChange : MonoBehaviour
{
    public int targetScene;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //Do scene change
            ChangeScene();
        }
    }

    void ChangeScene()
    {
        SceneManager.LoadScene(targetScene);
    }

}