using UnityEngine;

public class ResetPlayer : MonoBehaviour
{
    public GameObject respawnPoint;
    public GameObject healthBar, manaBar;

    public void OnReset()
    {
        //move player back to start when "dead"
        GetComponent<CharacterController>().enabled = false;
        gameObject.transform.position = respawnPoint.transform.position;
        GetComponent<CharacterController>().enabled = true;
        //reset health and mana
        GetComponent<HealthData>().currentHealth = GetComponent<HealthData>().definition.maxHealth;
        GetComponent<ManaData>().currentMana = GetComponent<ManaData>().definition.maxMana;
        //update health and mana bars
        healthBar.GetComponent<HealthBar>().OnHealthChanged();
        manaBar.GetComponent<ManaBar>().OnManaChanged();
    }

    public void ChangeRespawnPoint(GameObject newSpawn)
    {
        respawnPoint = newSpawn;
    }
}
