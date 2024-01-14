using UnityEngine;

public class Capsule : MonoBehaviour
{
    [SerializeField] private float _speed = 0.05f;

    private void Update()
    {
        Vector3 nextScale = transform.localScale;

        nextScale += new Vector3(_speed, _speed, _speed);

        transform.localScale = nextScale;   
    }
}
