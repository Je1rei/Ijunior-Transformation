using UnityEngine;

public class CubeLooker : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotateSpeed;
    [SerializeField] private float _scaleSpeed;

    private void Update()
    {
        transform.Rotate(0, 1 * _rotateSpeed * Time.deltaTime, 0);

        transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);

        Vector3 nextScale = transform.localScale;
        nextScale += new Vector3(_scaleSpeed, _scaleSpeed, _scaleSpeed);

        transform.localScale = nextScale;
    }
}
