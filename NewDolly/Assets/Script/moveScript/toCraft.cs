using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toCraft : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameManager.clear_l = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SceneChange()
    {
        SceneManager.LoadScene("craftScene");
    }
}
