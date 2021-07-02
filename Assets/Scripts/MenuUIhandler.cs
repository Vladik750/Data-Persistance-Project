using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuUIhandler : MonoBehaviour
{
    public InputField uname;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    public void StartNew()
    {
        if(uname.text == "")
        {
            Debug.Log("Name field is empty!");
        }
        else
        {
            MenuManager.Instance.userName = uname.text;
            MenuManager.Instance.LoadInfo();
            SceneManager.LoadScene(1);
            
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
