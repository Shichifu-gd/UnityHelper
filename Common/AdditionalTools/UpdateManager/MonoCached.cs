using System.Collections.Generic;
using UnityEngine;

public class MonoCached : MonoBehaviour
{
    public static List<MonoCached> AllTicks = new List<MonoCached>();
    public static List<MonoCached> AllFixedTicks = new List<MonoCached>();
    public static List<MonoCached> AllLateTicks = new List<MonoCached>();

    private void OnEnable()
    {
        AllTicks.Add(this);
    }

    private void OnDisable()
    {
        AllTicks.Remove(this);
    }

    public void Tick()
    {
        OnTick();
    }

    public void FixedTick()
    {
        OnFixedTick();
    }

    public void LateTick()
    {
        OnLateTick();
    }

    public virtual void OnTick() { }
    public virtual void OnFixedTick() { }
    public virtual void OnLateTick() { }
}