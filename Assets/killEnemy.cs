using UnityEngine;

public class killEnemy : MonoBehaviour
{

public Transform hitCheckPos;
public Vector2 hitCheckSize = new Vector2(0.5f, 0.1f);
public LayerMask playerLayer;


void Update()
{
    hitCheck();
}
private void hitCheck()
{
    if(Physics2D.OverlapBox(hitCheckPos.position, hitCheckSize, 0, playerLayer))
    {
        Destroy(gameObject);
    }

}

   private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(hitCheckPos.position, hitCheckSize);
    }

}
