using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class JadeManager : MonoBehaviour
{
    public List<GameObject> jadeOrder;
    public List<GameObject> playerOrder;

    public UnityEvent puzzleSolved;
    
    public void CheckOrder()
    {
        for (int i = 0; i < jadeOrder.Count; i++)
        {
            //if jadeorder and playerorder are the same
            if (jadeOrder[i] == playerOrder[i])
            {
                if(i == 4)
                {
                    //solved the puzzle
                    puzzleSolved.Invoke();
                }
            }

            else
            {
                //restart puzzle
                foreach (GameObject jade in jadeOrder)
                {
                    //starts puzzle over with startcolor
                    jade.GetComponent<ChangeColor>().ResetColor();
                }
                //empties playorder list
                playerOrder.Clear();
                //stops loop, once incorrect jade is picked and reset
                break;
            }
        }
    }

    public void AddToPlayerOrder(GameObject jade)
    {
        playerOrder.Add(jade);
        CheckOrder();
    }
}
