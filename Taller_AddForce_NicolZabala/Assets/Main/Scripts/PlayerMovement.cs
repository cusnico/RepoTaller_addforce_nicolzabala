using TMPro;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Transform _transform;
    [SerializeField] private Rigidbody2D _rb20;
    [SerializeField] private float x;

    [SerializeField] private TMP_Text uiLabel;
    [SerializeField] private string _Myname = "Nicol";
    [SerializeField] private int _edad = 18;
    [SerializeField] private int _añoActual = 2026;

    private void Start()
    {
        //Fuerza inical
        float x = Random.Range(-5, 25f);
        _rb20.AddForce(new Vector2(x, 0f), ForceMode2D.Impulse);

        //Movimiento
        _transform.position = new Vector3(-12.7f, 7.1f, 0f);

        //Texto
        int _añoNacimiento = _añoActual - _edad;
        uiLabel.text = $"Hola, mi nombre es {_Myname} y nací en el año {_añoNacimiento}.";
    }



}