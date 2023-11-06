using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstLevelButton : MonoBehaviour
{
    public void FirstLevel()
    {
        {
            SceneManager.LoadScene(1);
        }
    }
}
