using System;
using UnityEngine;

namespace Scripts.Game
{
	public class ParticlePlayer : MonoBehaviour
	{
		[SerializeField] private ParticleSystem particle;
		public static Action<Vector3> PlayParticle;

		private void Awake()
		{
			PlayParticle += ParticleHandle;
		}

		private void OnDestroy()
		{
			PlayParticle -= ParticleHandle;
		}

		private void ParticleHandle(Vector3 position)
		{
			particle.transform.position = position;
			particle.Play(true);
		}
	}
}