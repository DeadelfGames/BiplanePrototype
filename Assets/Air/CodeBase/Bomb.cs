using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] private GameObject _dieParticlePrefab;

    public void DieBomb()
    {
        Instantiate(_dieParticlePrefab, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
