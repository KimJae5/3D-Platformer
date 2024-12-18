using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        UnlockMouse(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UnlockMouse()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void load()
    {
        SceneManager.LoadScene("game");
    }
}
