using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProductionLine : MonoBehaviour
{
    private float _timer = 0.0f;

    public bool running = false;
    public float productionSpeed;
    public Potion potion;
    public GameManager gameManager;
    public GameObject button;

    void Update()
    {
        if (running == false) return;

        _timer += Time.deltaTime;

        if (_timer >= (productionSpeed))
        {
            _timer = 0;
            gameManager.IncreaseCredit(potion.price);
        }
    }
}
