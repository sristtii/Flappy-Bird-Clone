using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logic : MonoBehaviour
{
    public int playerscore;
    public Text scoretext;
    public GameObject gameoverscreen;
    [ContextMenu("increase score")]

    public void addscore(int score)
    {
        playerscore += score;
        scoretext.text = playerscore.ToString();
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameover(){
        gameoverscreen.SetActive(true);
    }

}
