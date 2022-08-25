using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUI : MonoBehaviour
{
    public string playerName;
    public TMP_InputField playerNameInputField;

    private PersistentData persistentData;

    // Start is called before the first frame update
    void Start()
    {
        persistentData = GameObject.Find("Persistent Data").GetComponent<PersistentData>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartNew()
    {
        persistentData.SetPlayerName();
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
