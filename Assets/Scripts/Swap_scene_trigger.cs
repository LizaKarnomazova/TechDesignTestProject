using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Swap_scene_trigger : MonoBehaviour
{
    [SerializeField] private string _sceneName;
    [SerializeField] private Button _swapSceneButton;

    private void OnMouseDown()
    {
        _swapSceneButton.gameObject.SetActive(true);
    }

    public void StartScene()
    {
        SceneManager.LoadScene(_sceneName);
    }
}
