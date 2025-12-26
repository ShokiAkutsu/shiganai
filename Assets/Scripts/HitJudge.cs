using UnityEngine;

public class HitJudge : MonoBehaviour
{
	[SerializeField] CharacterDataSO _data;
	bool _isHit = false;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (_data.IsChange && !_isHit)
		{
			float scaleX = collision.transform.lossyScale.x;
			float currentZ = collision.transform.localEulerAngles.z;

			float diff = Mathf.DeltaAngle(currentZ, _data.MatchAngle);

			if (Mathf.Abs(diff) < 1.0f && scaleX == _data.MatchScale)
			{
				_isHit = true;
				
				Transform child = transform.GetChild(0); // •¶Žš‚ð•Ï‰»‚³‚¹‚éˆ—
				SpriteRenderer sr = child.GetComponent<SpriteRenderer>();
				sr.sprite = _data.ChangeSprite;

				Destroy(collision.gameObject);
			}
		}
	}
}
