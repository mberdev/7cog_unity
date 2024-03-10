using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    [SerializeField]
    public string SceneToLoad;

    // To be used in an ActivationTrack
    void OnEnable()
    {
        SceneManager.LoadScene(SceneToLoad, LoadSceneMode.Single);
    }
}
