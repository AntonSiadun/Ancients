using UnityEngine;

public class GameRules : MonoBehaviour
{
    [SerializeField]
    private Health _characterHealth;
    [SerializeField]
    private MenuActor _menu;

    private void Update() 
    {
        if(_characterHealth.hp <= 0)
        EndGame();

    }

    private void EndGame()
    {
        _menu.ShowUIElement();
    }
}
