using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

    bool gamend = false;
    public float delay = 1f;
    public GameObject completescreen;
 
    public void completelvl()
    {
        completescreen.SetActive(true);
    }
    public void EndGame()
    {
        if (gamend == false)
        {
            gamend = true;
            Debug.Log("Kaybettin");
            Invoke("restart",delay);
        }
        
    }
    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
   
}
