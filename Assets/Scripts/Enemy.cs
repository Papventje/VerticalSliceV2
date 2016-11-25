using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    private int fallDamage;

	void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Bird")
        {
            Destroy(this.gameObject);
            Score.score += 500;
        }
        if (Mathf.Abs(other.relativeVelocity.y) > 5f)
        {
            Destroy(this.gameObject);
            Score.score += 500;
        }
    }
}
