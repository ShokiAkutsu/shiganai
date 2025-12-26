using UnityEngine;
using DG.Tweening;

public class Bullet : MonoBehaviour
{
	Shooting _shoot;
	//[SerializeField] float _speed = 2f;

	void Start()
    {
		_shoot = GameObject.FindAnyObjectByType<Shooting>();

		transform.localScale = Vector3.one * 0.1f;
		transform.DOScale(1f, _shoot.IntervalTime);
	}
}
