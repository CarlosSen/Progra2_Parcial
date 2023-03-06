using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VidaEnemigos : MonoBehaviour
{
    public Transform sangre;
    
    public int vida;
    public int cantidad;

    public void Danio(int golpe)
    {
        vida -= golpe;
        if (vida <= 0)
        {
            Instantiate(sangre, transform.position, transform.rotation);
            GameManager.instance.enemigos += cantidad;
            Destroy(gameObject);

            if (GameManager.instance.enemigos == 10)
            {
                SceneManager.LoadScene("Escenanueva");
            }


        }

    }

}
