using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KillCounterScript : MonoBehaviour
{
    [SerializeField]
    public int killCounter;
    // Start is called before the first frame update
    public Text killCounterText;
    public Text winLooseText;


    void Start()
    {
        winLooseText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        //UpdateKillCounter();
    }

    public void UpdateKillCounter()
    {
        Debug.Log("Update KillCounter");
        killCounterText.text = "Kills: " + killCounter;
        if(killCounter >= 25)
        {
            StartCoroutine(WinRoutine());
        }
    }

    public void UpdateGameLost()
    {
        StartCoroutine(GameOverRoutine());
    }

    IEnumerator GameOverRoutine()
    {
        winLooseText.text = "You have lost!";
        winLooseText.color = Color.red;
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    IEnumerator WinRoutine()
    {
        winLooseText.color = Color.green;
        winLooseText.text = "You have won!";
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
