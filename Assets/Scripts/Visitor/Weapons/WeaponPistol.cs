using UnityEngine;

public class WeaponPistol : ShootingWeapon
{
    public override int GetDamage()
    {
        return 5;
    }

    protected override void ApplyHit(BodyPart bodyPart, RaycastHit2D hit)
    {
        bodyPart.Visit(this, hit);
    }
}
