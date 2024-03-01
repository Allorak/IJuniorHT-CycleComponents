using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        Vector3 stepDistance = _speed * Time.deltaTime * transform.forward;
        transform.Translate(stepDistance);
    }
}
