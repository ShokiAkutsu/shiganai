using UnityEngine;

[CreateAssetMenu(fileName = "CharacterDataSO", menuName = "Scriptable Objects/CharacterDataSO")]
public class CharacterDataSO : ScriptableObject
{
	[SerializeField] Sprite _changeSprite; // isChange = false;‚È‚çÝ’è‚µ‚È‚¢
	[Header("”»’èðŒ")]
	[SerializeField] float _matchAngle = 0f; 
	[SerializeField] float _matchScale = 1f;

	public Sprite ChangeSprite => _changeSprite;
	public float MatchAngle => _matchAngle;
	public float MatchScale => _matchScale;
}
