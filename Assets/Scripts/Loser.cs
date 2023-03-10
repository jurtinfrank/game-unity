using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Loser : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private TMP_Text textRecord;

    

    private void Start()
    {
        var score = PlayerPrefs.GetInt("score");
        var PuntajeRecord = PlayerPrefs.GetInt("PuntajeRecord");
        _scoreText.text = score.ToString();
        textRecord.text = PuntajeRecord.ToString();
    }

    public void RestarGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuiToMenu()
    {
        SceneManager.LoadScene(0);
    }

    

}
