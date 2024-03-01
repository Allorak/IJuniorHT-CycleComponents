using UnityEngine;

public class Grower : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.localScale += new Vector3(_speed, _speed, _speed);
    }
}
