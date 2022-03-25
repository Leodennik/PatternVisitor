using UnityEngine;

[RequireComponent(typeof(WeaponAttacker))]
public class InputController : MonoBehaviour
{
    private Camera _camera;
    private WeaponAttacker _weaponAttacker;

    private void Awake()
    {
        _camera = Camera.main;
        _weaponAttacker = GetComponent<WeaponAttacker>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 aimPosition = _camera.ScreenToWorldPoint(Input.mousePosition);
            _weaponAttacker.Shoot(aimPosition);
        }
        
        if (Input.GetMouseButtonDown(1))
        {
            Vector2 aimPosition = _camera.ScreenToWorldPoint(Input.mousePosition);
            _weaponAttacker.Hit(aimPosition);
        }
    }
}