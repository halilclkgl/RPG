using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RPG.Core
{
    public class Health : MonoBehaviour
    {
        [SerializeField] float healtPoint = 100f;
        bool isDead = false;
        public void TakeDamage(float damage) 
        {
            healtPoint = Mathf.Max(healtPoint - damage,0);
            if (healtPoint==0)
            {
               
                Die();
            }  
        }
        public bool IsDead() 
        {
            return isDead;
        }
        private void Die() 
        {
            if (isDead) return;

            isDead= true;

            GetComponent<Animator>().SetTrigger("die");
            GetComponent<ActionScheduler>().CancalCurrentAction();
        }
    }
}
