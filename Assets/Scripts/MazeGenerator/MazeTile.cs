using UnityEngine;

public enum NodeState
{
    Available,
    Current,
    Completed
}

public class MazeTile : MonoBehaviour
{
    [SerializeField] GameObject[] tileWalls;
    [SerializeField] MeshRenderer floor;                //to change the color of the 

    public void RemoveWall(int wallToRemove)
    {
        tileWalls[wallToRemove].gameObject.SetActive(false);
    }

    public void SetState(NodeState state)
    {
        switch (state)
        {
            case NodeState.Available:
                floor.material.color = Color.white;
                break;
            case NodeState.Current:
                floor.material.color = Color.yellow;
                break;
            case NodeState.Completed:
                floor.material.color = Color.blue;
                break;
        }
    }
}