using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public InputField inputName;
    public string playerName;
    public static MenuManager Instance;
    public static int count = 0;

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void OnStartClick() {
        playerName = inputName.text;
        SceneManager.LoadScene(1);
    }
}
