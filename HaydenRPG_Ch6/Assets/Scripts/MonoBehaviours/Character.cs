using System.Collections;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    public float startingHitPoints;
    public float maxHitPoints;

    public virtual void KillCharacter()
    {
        Destroy(gameObject);
    }
    public abstract void ResetCharacter();
    public abstract IEnumerator DamageCharacter(int damage, float interval);
}