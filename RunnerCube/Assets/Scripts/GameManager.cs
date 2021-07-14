using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f; //1second
    public GameObject completeLevelUI;
    // Start is called before the first frame update

    public void CompleteLevel() {
        completeLevelUI.SetActive(true); 
    }
     public void EndGame() {
        if (!gameHasEnded)
        {
            Debug.Log("GameOver");
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
        
    }
    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    } 
}
