using UnityEngine;

public class BiplaneTrigger : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private Score _score;
    
    private void OnTriggerEnter(Collider other)
    {
        Bomb bomb = other.gameObject.GetComponent<Bomb>();
        if (bomb)
        {
            _health -= 1;
            if (_health <= 0)
            {
                Destroy(gameObject);
            }
            bomb.DieBomb();
        }

        Coin coin = other.gameObject.GetComponent<Coin>();

        if (coin)
        {
            coin.DieCoin();
            _score.AddOne();
        }
    }
}
