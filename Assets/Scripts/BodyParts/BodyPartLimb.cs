using UnityEngine;

public class BodyPartLimb : BodyPart
{
    protected override void Start()
    {
        base.Start();
    }
    
    public override void Visit(WeaponFist weapon)
    {
        base.Visit(weapon);
    }

    public override void Visit(WeaponPistol weapon, RaycastHit2D hit)
    {
        base.Visit(weapon, hit);
    }
}
