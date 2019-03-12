using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombPlatform : MonoBehaviour
{

	
    public CircleCollider2D blastRadius;

    private void Start()
    {
        blastRadius = GetComponent<CircleCollider2D>();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "player")
        {
            StartCoroutine(PlatformDestruction());
        }
    }
    IEnumerator PlatformDestruction()
    {
        yield return new WaitForSeconds(3);
        blastRadius.enabled = !blastRadius.enabled;
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }


   // void ExplosionDamage(Vector2 point, float radius, int layerMask)
  //  {
  //      Collider2D[] hitColliders = Physics2D.OverlapCircleAll(, radius, layerMask);
    //    int i = 0;
    ///    while (i < hitColliders.Length)
     //   {
      //      hitColliders[i].transform.gameObject.CompareTag(Destroy);
      //      i++;
      //  }
   // }
}

