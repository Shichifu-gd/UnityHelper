using System.Collections.Generic;
using UnityEngine;

public static class FrameworkExtension
{
    private static System.Random MainRandom = new System.Random();

    public static void SetAlpha(this SpriteRenderer spriteRenderer, float alpha)
    {
        var color = spriteRenderer.color;
        spriteRenderer.color = new Color(color.r, color.g, color.b, alpha);
    }

    public static Color SetAlpha(this Color color, float alpha)
    {
        return new Color(color.r, color.g, color.b, alpha);
    }

    public static T Random<T>(this List<T> list)
    {
        var val = list[UnityEngine.Random.Range(0, list.Count)];
        return val;
    }

    public static T RandomByChance<T>(this List<T> list) where T : IRandom
    {
        var total = 0f;
        var array = new float[list.Count];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = list[i].returnChance;
            total += array[i];
        }
        var randomPoint = (float)MainRandom.NextDouble() * total;
        for (int i = 0; i < array.Length; i++)
        {
            if (randomPoint < array[i]) return list[i];
            randomPoint -= array[i];
        }
        return list[0];
    }

    public static Vector3 Center(this List<Transform> points)
    {
        Vector3 finalPosition = Vector3.zero;
        for (int i = 0; i < points.Count; i++)
        {
            finalPosition += points[i].position;
        }
        finalPosition /= points.Count;
        return finalPosition;
    }
}