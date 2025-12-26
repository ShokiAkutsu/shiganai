using UnityEngine;
using DG.Tweening;

public class Bullet : MonoBehaviour
{
	Shooting _shoot;

	void Start()
    {
		_shoot = GameObject.FindAnyObjectByType<Shooting>();

		transform.localScale = Vector3.one * 0.1f;
		transform.DOScale(1f, _shoot.IntervalTime);
	}
}
