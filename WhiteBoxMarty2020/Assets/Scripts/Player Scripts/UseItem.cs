using UnityEngine;

public class UseItem : MonoBehaviour
{
    public GameObject player;
    public void OnClick()
    {
        if (GetComponent<PickUp>().pickUps == PickUp.pickUpType.HEALTH)
        {
            player = GameObject.Find("First Person Player");
            if (player.GetComponent<HealthData>().currentHealth < player.GetComponent<HealthData>().maxHealth)
            {
                player.GetComponent<HealthData>().Heal();
                Destroy(gameObject);
            }
        }
        if (GetComponent<PickUp>().pickUps == PickUp.pickUpType.MANA)
        {
            player = GameObject.Find("First Person Player");
            player.GetComponent<ManaData>().ManaIncrease();
        }
    }
}
