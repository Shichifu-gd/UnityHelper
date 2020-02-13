using UnityEngine;
using System;

public class View : MonoBehaviour, IView
{
    public event Action<int> OnTakeDamge;
    public event Action<int> OnUpdateValues;
    public event Action<float> OnUpdateLife;

    public void HealthAnimation(int health, int maxHealth)
    {
        float num = health;
        OnUpdateLife.Invoke(num / maxHealth);
    }

    public void ObjectShutdown()
    {

    }
}