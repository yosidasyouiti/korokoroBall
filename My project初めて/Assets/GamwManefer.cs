using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamwManefer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SceneReset()
    {
        string activeSceneNama = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(activeSceneNama);
    }
    public void ChangeScene(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
    }
}
