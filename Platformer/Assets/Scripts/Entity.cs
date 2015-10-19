using UnityEngine;
using System.Collections;

public class Entity : MonoBehaviour {
	
	public float health;
	protected bool dead;
	
	public void TakeDamage(float dmg) {
		health -= dmg;
		
		if (health <= 0) {
			Die();	
		}
	}
	
	public void Die() {
		dead = true;
		Destroy(this.gameObject,1.5f);
	}
}
