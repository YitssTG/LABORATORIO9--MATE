using UnityEngine;

public class PersecucionMRUV : MonoBehaviour
{
    public Transform objetivo;
    public float velocidadInicial;
    public float aceleracion;
    private float tiempo = 0f;

    void Update()
    {
        tiempo += Time.deltaTime;
        float velocidadActual = velocidadInicial + aceleracion * tiempo;
        Vector3 direccion = (objetivo.position - transform.position).normalized;
        transform.position += direccion * velocidadActual * Time.deltaTime;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Enemigo alcanzo al player.... ");
            Destroy(this.gameObject);
        }
    }
}
