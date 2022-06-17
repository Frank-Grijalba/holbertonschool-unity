using UnityEngine;
using UnityEngine.SceneManagement;


public class OptionsMenu : MonoBehaviour
{

    public void Options()
    {
        SceneManager.LoadScene(4);
    }

    public void Back()
    {
        SceneManager.LoadScene(0);
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Exited");
    }

}
