using UnityEngine;

public class WeaponFist : MeleeWeapon
{
    public override int GetDamage()
    {
        return 2;
    }

    protected override void ApplyHit(BodyPart bodyPart, RaycastHit2D hit)
    {
        bodyPart.Visit(this);
    }
}
