using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonController : MonoBehaviour
{
    public void GoBackToPreviousScene()
    {
       
            SceneManager.LoadScene(0);
        
    }
}
