using UnityEngine;

public class Coin : MonoBehaviour
{
    public void DieCoin()
    {
        Destroy(this.gameObject);
    }
}
