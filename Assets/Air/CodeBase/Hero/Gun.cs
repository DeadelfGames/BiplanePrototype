using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private float _speedBullet;
    [SerializeField] private AudioSource _shotAudio;

    private float _shotPeriod = 0.20f;
    private float _timer;


    private void Update()
    {
        _timer += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_timer > _shotPeriod)
            {
                _timer = 0;
                CreateBullet();
            }

        }
    }

    private void CreateBullet()
    {
        GameObject newBullet = Instantiate(_bulletPrefab, transform.position, transform.rotation, transform);
        newBullet.GetComponent<Rigidbody>().velocity = transform.forward * _speedBullet;

        _shotAudio.pitch = Random.Range(0.7f, 1.2f);
        _shotAudio.Play();
    }

}
