using UnityEngine;

[RequireComponent(typeof(Health))]
[RequireComponent(typeof(ShakeEffect))]
public abstract class BodyPart : MonoBehaviour, IWeaponVisitor
{
    private Health _health;
    private Character _character;
    private ShakeEffect _shake;

    protected virtual void Awake()
    {
        _health = GetComponent<Health>();
        _shake  = GetComponent<ShakeEffect>();
    }

    protected virtual void Start()
    {
        
    }
    
    protected void ApplyDamage(int damage)
    {
        _health.AddValue(-damage);
    }
    
    public virtual void Visit(WeaponFist weapon)
    {
        DefaultOverlapVisit(weapon);
    }

    public virtual void Visit(WeaponPistol weapon, RaycastHit2D hit)
    {
        DefaultRaycastVisit(weapon, hit);
    }
    
    protected void DefaultOverlapVisit(Weapon weapon, int damageMultiplier = 1)
    {
        int damage = weapon.GetDamage() * damageMultiplier;
        ApplyDamage(damage);
        _shake.Begin();
    }
    
    protected void DefaultRaycastVisit(Weapon weapon, RaycastHit2D hit, int damageMultiplier = 1)
    {
        int damage = weapon.GetDamage() * damageMultiplier;
        ApplyDamage(damage);
        SpawnDecal(Decals.Instance.hole, hit);
    }

    private void SpawnDecal(Decal decalHole, RaycastHit2D hit)
    {
        Instantiate(decalHole, hit.point, Quaternion.identity, transform);
    }
}