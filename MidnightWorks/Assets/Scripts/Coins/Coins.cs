using UnityEngine;

public class Coins : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out LifeControllre lifeControllre))
        {
            lifeControllre.PickLife();
            gameObject.SetActive(false);
        }
    }
}
