using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickSort : MonoBehaviour
{
    static bool flag = false;
    public static void SortBulletStack(Stack<BulletTemplate> data)
    {
        SortStack(data);
    }
    private static void SortStack(Stack<BulletTemplate> data)
    {
        var datos = QuicksortMethod(data.ToArray(), 0, data.Count - 1);
        data.Clear();
        for (int i = 0; i < datos.Length; i++)
        {
            Debug.LogError($"danio ordenado: {datos[i].damage}");
            data.Push(datos[i]);
        }
    }

    private static BulletTemplate[] QuicksortMethod(BulletTemplate[] datos, int left, int right)
    {
        for (int k = 0; k < datos.Length; k++)
        {
            Debug.LogError($"danio desordenado: {datos[k].damage}");
        }
        int i = left;
        int j = right;
        int pivotIndex = (left + right) / 2;
        // Debug.LogError($"pivot index: {pivotIndex}, count total = {datos.Length}");
        var pivot = datos[pivotIndex];

        while (i <= j)
        {
            while (datos[i].damage < pivot.damage)
                i++;

            while (datos[j].damage > pivot.damage)
                j--;

            if (i <= j)
            {
                Debug.LogError($"reemplazando: {datos[i].damage} por {datos[j].damage}");
                var tmp = datos[i];
                datos[i] = datos[j];
                datos[j] = tmp;
                Debug.LogError($"datos i = {datos[i].damage}, datos j = {datos[j].damage}");
                i++;
                j--;
            }
        }
        if (left < j)
            QuicksortMethod(datos, left, i);
        if (i < right)
            QuicksortMethod(datos, i, right);
        return datos;
    }
}
