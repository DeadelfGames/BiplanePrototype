using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private int _coins;
    [SerializeField] private Text _text;

    public void AddOne()
    {
        _coins += 1;
        _text.text = _coins.ToString();
    }
}
