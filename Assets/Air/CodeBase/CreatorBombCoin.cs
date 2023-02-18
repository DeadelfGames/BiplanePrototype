using UnityEngine;

public class CreatorBombCoin : MonoBehaviour
{
    [SerializeField] private GameObject _coinPrefab;
    [SerializeField] private GameObject _bombPrefab;

    private void Start()
    {
        for (int i = 0; i < 50; i++)
        {
            Vector3 position = new Vector3(0, Random.Range(15, -15), i);
            if (Random.Range(0, 4) == 0)
            {
                Instantiate(_bombPrefab, position, Quaternion.identity);
            }
            else
            {
                Instantiate(_coinPrefab, position, Quaternion.identity);
            }
        }
    }
}
