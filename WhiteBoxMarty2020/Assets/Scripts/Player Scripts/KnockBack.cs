using UnityEngine;

public class KnockBack : MonoBehaviour
{
    public float knockBackSpeed = 3f;

    public void KnockedBack(GameObject enemy)
    {
        Vector3 newPosition;
        //When player is attacked, get position of enemy (done in hitbox script)
        //Get vector from the two positions
        newPosition = gameObject.transform.position - enemy.transform.position;
        //Use controller.move to move player
        GetComponent<CharacterController>().Move(newPosition * knockBackSpeed);
    }
}
