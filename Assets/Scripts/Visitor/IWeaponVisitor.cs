using UnityEngine;

public interface IWeaponVisitor
{
    public void Visit(WeaponFist  weapon);
    public void Visit(WeaponPistol  weapon, RaycastHit2D hit);
}
