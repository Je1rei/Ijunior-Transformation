using UnityEngine;
using UnityEngine.UIElements;

public class Cube : MonoBehaviour
{

    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Rotate(0, 1 * _speed * Time.deltaTime, 0);
    }
}
