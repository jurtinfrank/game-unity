using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuSeleccion : MonoBehaviour
{
    private int index;

    [SerializeField] private Image image;
    
    [SerializeField] private TextMeshProUGUI nombre;

    private GameManager gameManager;

    private void Start()
    {
        gameManager = GameManager.Instance;
        index = PlayerPrefs.GetInt("JugadorIndex");
        if (index > gameManager.personajes.Count - 1)
        {
            index = 0;
        }
        cambiarPantalla();
    }

    private void cambiarPantalla()
    {
        PlayerPrefs.SetInt("JugadorIndex", index);
        image.sprite = gameManager.personajes[index].imagen;
        nombre.text = gameManager.personajes[index].nombre;
    }

    public void siguientePersonaje()
    {
        if(index == gameManager.personajes.Count - 1)
        {
            index = 0;
        }

        else
        {
            index += 1;
        }

        cambiarPantalla();
    }

    public void anteriorPersonaje()
    {
        if (index == 0)
        {
            index = gameManager.personajes.Count - 1;
        }

        else
        {
            index -= 1;
        }

        cambiarPantalla();
    }

    public void inciarJuego()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
