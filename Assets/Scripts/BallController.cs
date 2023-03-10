using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    [SerializeField] private int _score;
    [SerializeField] private TextMeshProUGUI _scoreText;
    [SerializeField] private TextMeshProUGUI textRecord;


    private void Awake()
    {
        _score = 0;
        textRecord.text = PlayerPrefs.GetInt("PuntajeRecord", 0).ToString();

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.gameObject.CompareTag("Bonus"))
        {
            _score++;
            _scoreText.text = _score.ToString();
            Destroy(collision.gameObject);
        }

       if (collision.gameObject.CompareTag("Enemy"))
        {
            PlayerPrefs.SetInt("score", _score);
            SceneManager.LoadScene(2);
        }

        if (collision.gameObject.CompareTag("Bonustwo"))
        {
            _score++;
            _scoreText.text = _score.ToString();
            Destroy(collision.gameObject);
        }

        if (_score > PlayerPrefs.GetInt("PuntajeRecord", 0))
        {
            PlayerPrefs.SetInt("PuntajeRecord", _score);
            textRecord.text = _score.ToString();
        }
    }

    public void borrarDatos()
    {

    }
}
