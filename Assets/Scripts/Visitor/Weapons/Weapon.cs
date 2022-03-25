using System;
using UnityEngine;

public abstract class Weapon
{
    public abstract int GetDamage();
    protected abstract void ApplyHit(BodyPart bodyPart, RaycastHit2D hit);

    public void PerformAttack(Vector2 position)
    {
        int layerDamageable = LayerMask.GetMask("Damageable");
        RaycastHit2D hit = Physics2D.Raycast(position, Vector2.zero, 10, layerDamageable);

        if (hit.collider != null)
        {
            ScanHit(hit);
        }
    }

    private void ScanHit(RaycastHit2D hit)
    {
        BodyPart bodyPart = hit.collider.GetComponent<BodyPart>();
        if (bodyPart == null) throw new Exception(hit.collider.name + " doesn't have 'Damageable' component!");
        ApplyHit(bodyPart, hit);
    }
    
}
