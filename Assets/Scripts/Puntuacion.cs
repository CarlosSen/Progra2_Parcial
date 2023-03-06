
using TMPro;
using UnityEngine;

public class Puntuacion : MonoBehaviour
{
    private TextMeshProUGUI pro;

    private void Start()
    {

        pro = GetComponent<TextMeshProUGUI>();

    }

    private void Update()
    {

        pro.text = GameManager.instance.enemigos.ToString();

    }
}
