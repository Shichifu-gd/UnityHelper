using UnityEngine;

public class Example_Update : MonoCached
{
    private int testOnTick = 0;
    private int testOnFixedTick = 0;
    private int testOnLateTick = 0;

    public override void OnTick()
    {
        Debug.Log($"OnTick: {testOnTick}");
        testOnTick++;
    }

    public override void OnFixedTick()
    {
        Debug.Log($"OnFixedTick: {testOnFixedTick}");
        testOnFixedTick++;
    }

    public override void OnLateTick()
    {
        Debug.Log($"OnLateTick: {testOnLateTick}");
        testOnLateTick++;
    }
}