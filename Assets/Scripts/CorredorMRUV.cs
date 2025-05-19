using UnityEngine;

public class CorredorMRUV : MonoBehaviour
{
    public Transform destino;
    public float velocidadInicial = 0f;
    public float aceleracion = 2f;

    private float velocidadActual = 0f;

    void Start()
    {
        velocidadActual = velocidadInicial;
    }

    void Update()
    {
        Vector3 direccion = (destino.position - transform.position).normalized;

        velocidadActual += aceleracion * Time.deltaTime;

        transform.position += direccion * velocidadActual * Time.deltaTime;
    }
}
