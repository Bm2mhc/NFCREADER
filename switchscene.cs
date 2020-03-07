using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switchscene : MonoBehaviour
{
    // Start is called before the first frame update


    // Update is called once per frame
    public void NextScene()
    {
        SceneManager.LoadScene("Login");
    }

    public void logout()
    {
        SceneManager.LoadScene("Logout");
    }
    public void back()
    {
        SceneManager.LoadScene("Start");
    }
}
