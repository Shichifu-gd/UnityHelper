using UnityEngine;

public class UpdateManager : MonoBehaviour
{
    private void Update()
    {
        for (int index = 0; index < MonoCached.AllTicks.Count; index++)
        {
            MonoCached.AllTicks[index].Tick();
        }
    }

    private void FixedUpdate()
    {
        for (int index = 0; index < MonoCached.AllFixedTicks.Count; index++)
        {
            MonoCached.AllFixedTicks[index].FixedTick();
        }
    }

    private void LateUpdate()
    {
        for (int index = 0; index < MonoCached.AllLateTicks.Count; index++)
        {
            MonoCached.AllLateTicks[index].LateTick();
        }
    }
}