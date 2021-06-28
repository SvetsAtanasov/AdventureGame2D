using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable
{
    void DestroyItem();
}

public interface IDamageSource
{

}

public interface IDamagable
{
    void Damage(int damage, IDamageSource source);
}