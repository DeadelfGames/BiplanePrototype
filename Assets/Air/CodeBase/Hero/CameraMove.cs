using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private Transform _target;

    void Update()
    {
        if (_target)
        {
            transform.position = _target.position;
        }
    }
}
