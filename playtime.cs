using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playtime : MonoBehaviour
{
    [SerializeField]
    private float countdownTime = 3.0f; // Editable countdown time

    [SerializeField]
    private float gameTime = 60.0f; // Editable total game time

    //private bool IsGameStarted = false;

    public bool IsGameStarted = false;
    // Start is called before the first frame update
    void Start()
    {
        IsGameStarted = false;
    }

    public void ToggleGame()
    {
        IsGameStarted = !IsGameStarted;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
