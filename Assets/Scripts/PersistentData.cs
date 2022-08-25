using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PersistentData : MonoBehaviour
{
    public static PersistentData Instance;

    public string playerName;
    public TMP_InputField playerNameInputField;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void SetPlayerName()
    {
        if (string.IsNullOrEmpty(playerNameInputField.text))
        {
            playerName = "Anonymous";
        }
        else
        {
            playerName = playerNameInputField.GetComponent<TMP_InputField>().text;
        }
    }
}
