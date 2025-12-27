using UnityEngine;

[CreateAssetMenu(fileName = "CharacterDataSO", menuName = "Scriptable Objects/CharacterDataSO")]
public class CharacterDataSO : ScriptableObject
{
	[SerializeField] Sprite _changeSprite; // •ÏXŒã‚Ì•¶Žš‚ðŠi”[
	[Header("”»’èðŒ")]
	[SerializeField] float _matchAngle = 0f; 

	public Sprite ChangeSprite => _changeSprite;
	public float MatchAngle => _matchAngle;
}