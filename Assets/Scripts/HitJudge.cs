using UnityEngine;

public class HitJudge : MonoBehaviour
{
	[SerializeField] CharacterDataSO _data; // 
	bool _isHit = false; // Š¿š•ÏŠ·‚µ‚½‚çtrue

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (_data && !_isHit)
		{
			float scaleX = collision.transform.lossyScale.x;
			float currentZ = collision.transform.localEulerAngles.z;

			float diff = Mathf.DeltaAngle(currentZ, _data.MatchAngle);

			if (Mathf.Abs(diff) < 1.0f && scaleX == _data.MatchScale)
			{
				_isHit = true;
				
				Transform child = transform.GetChild(0); // •¶š‚ğ•Ï‰»‚³‚¹‚éˆ—
				SpriteRenderer sr = child.GetComponent<SpriteRenderer>();
				sr.sprite = _data.ChangeSprite;

				if(child.childCount > 0) // ‘·‚ª‚¢‚é‚È‚çAHide‚É‚·‚é
				{
					foreach (Transform g in child)
					{
						g.gameObject.SetActive(false);
					}
				}

				Destroy(collision.gameObject);
			}
		}
	}
}
