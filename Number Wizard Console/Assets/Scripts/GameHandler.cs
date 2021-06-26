using UnityEngine;

public class GameHandler : MonoBehaviour {
    
    [SerializeField] private int startMin = 1;
    [SerializeField] private int startMax = 1000;

    private int _min;
    private int _max;
    private int _guess;
    
    private void Start() {
       StartGame(); 
    }

    private void StartGame() {
        _min = startMin;
        _max = startMax;
        _guess = (startMax + startMin) / 2;
        
        Debug.Log("Welcome to Number Wizard Console");
        Debug.Log("Pick a number in your head between " + startMin + " and " + startMax);
        Debug.Log("Tell me if your number is higher or lower than " + _guess);
        Debug.Log("Press Up for higher, Down for lower and Enter if it's correct");

        _max++;
    }
    
    private void Update() {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            _min = _guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            _max = _guess;
            NextGuess();
        }
        
        else if (Input.GetKeyDown(KeyCode.Return)) {
            Debug.Log("The correct number was " + _guess);
            StartGame();
        }
        
        else if (Input.GetKeyDown(KeyCode.Escape)) {
            StartGame();
        }
    }

    private void NextGuess() {
        _guess = (_max + _min) / 2;
        Debug.Log("Is the number " + _guess + " ?");
    }
}
