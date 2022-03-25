using UnityEngine;

public class WeaponAttacker : MonoBehaviour
{
    private WeaponFist weaponFist;
    private WeaponPistol weaponPistol;

    private void Awake()
    {
        weaponFist = new WeaponFist();
        weaponPistol = new WeaponPistol();
    }

    public void Hit(Vector2 aimPosition)
    {
        weaponFist.PerformAttack(aimPosition);
    }

    public void Shoot(Vector2 aimPosition)
    {
        weaponPistol.PerformAttack(aimPosition);
    }
}
