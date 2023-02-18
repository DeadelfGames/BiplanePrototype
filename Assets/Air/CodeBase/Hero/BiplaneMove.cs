using UnityEngine;

public class BiplaneMove : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;

    [SerializeField] private float _forceValue;
    [SerializeField] private float _torqueValue;

    private float _constForceValue = 0.2f;
    private void FixedUpdate()
    {
        _rigidbody.AddForce(transform.forward * _constForceValue, ForceMode.VelocityChange);

        if (Input.GetKey(KeyCode.W))
        {
            _rigidbody.AddForce(transform.forward * _forceValue, ForceMode.VelocityChange);
        }

        float inputHorizontalValue = Input.GetAxis("Horizontal");
        _rigidbody.AddTorque(transform.right * _torqueValue * inputHorizontalValue, ForceMode.VelocityChange);

    }

}
