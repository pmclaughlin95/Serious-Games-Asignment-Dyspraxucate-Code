// SceneB.
// SceneB is given the sceneBuildIndex of 0 which will
// load SceneA from the Build Settings

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelSwitch : MonoBehaviour
{
    [SerializeField] private string LoadLevel;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        { 
                SceneManager.LoadScene(LoadLevel);
        }
       
      
    }
    public void SceneLoad(string LoadLevel)
    {
        SceneManager.LoadScene(LoadLevel);

    }

    }