using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Actor", menuName = "Scriptable Object/Actor", order = 0)]
public class ActorStats : ScriptableObject
{
    [SerializeField] private float speed;
    [SerializeField] private float life;

    public float Speed { get => speed; }
    public float Life { get => life; }
}
