using Scripts.Game;
using UnityEngine;
using DG.Tweening;


public class Obstacle : MonoBehaviour
{
    [SerializeField] private int damage = 1;


    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out LifeControllre lifeControllre))
        {
            lifeControllre.TakeDamage(damage);
            ShakeCamera();

            ParticlePlayer.PlayParticle.Invoke(transform.position);
            gameObject.SetActive(false);
        }        
    }

    private void ShakeCamera()
    {
        Quaternion rotation = Camera.main.transform.rotation;
        Camera.main.transform.DOShakeRotation(0.2f, 1.5f).OnComplete(()=>Camera.main.transform.rotation = rotation);
    }
}
