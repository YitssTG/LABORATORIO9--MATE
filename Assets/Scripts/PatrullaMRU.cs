using UnityEngine;

public class PatrullaMRU : MonoBehaviour
{
    public Transform[] puntos;   
    public float[] tiempos;           

    private int point = 0;
    private int nextPont = 1;

    private float _speed;
    private Vector3 _direction;

    void Start()
    {
        transform.position = puntos[nextPont].position;
        CalcularMovimiento();
    }

    void Update()
    {
        transform.position += _direction * _speed * Time.deltaTime;

        float distanciaRestante = Vector3.Distance(transform.position, puntos[nextPont].position);

        if (distanciaRestante < 0.5f) 
        {
            point = nextPont;
            nextPont = (nextPont + 1) % puntos.Length;

            Debug.Log("Llego al punto: " + point);
            CalcularMovimiento();
        }
    }

    void CalcularMovimiento()
    {
        Vector3 delta = puntos[nextPont].position - puntos[point].position;
        _direction = delta.normalized;

        float tiempo = tiempos[point];

        if (tiempo <= 0)
        {
            tiempo = 1f;
        }

        _speed = delta.magnitude / tiempo;
    }
}