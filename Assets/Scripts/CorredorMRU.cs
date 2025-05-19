using UnityEngine;

public class CorredorMRU : MonoBehaviour
{
    public Transform destino;
    public float _speed = 5f;

    void Update()
    {
        Vector3 direccion = (destino.position - transform.position).normalized;
        transform.position += direccion * _speed * Time.deltaTime;
    }
}