using UnityEngine.SceneManagement;

public class SceneController : PangElement
{
    public void ReloadScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.buildIndex);
    }

    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}
