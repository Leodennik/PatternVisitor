using UnityEngine;

public class BodyPartHead : BodyPart
{
    private BlinkEffect _blinkEffect;

    protected override void Awake()
    {
        base.Awake();
        _blinkEffect = GetComponent<BlinkEffect>();
    }

    public override void Visit(WeaponFist weapon)
    {
        DefaultOverlapVisit(weapon, 2); // Visit with double damage
        _blinkEffect.StartBlink();
    }

    public override void Visit(WeaponPistol weapon, RaycastHit2D hit)
    {
        DefaultRaycastVisit(weapon, hit, 2); // Visit with double damage
        _blinkEffect.StartBlink();
    }
}
