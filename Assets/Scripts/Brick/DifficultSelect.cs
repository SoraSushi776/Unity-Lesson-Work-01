using UnityEngine;

public class DifficultSelect : MonoBehaviour
{
    public BuildABrickWall buildBrickWall;

    public void Easy()
    {
        buildBrickWall.wallWidth = 5;
        buildBrickWall.wallHeight = 8;
        buildBrickWall.GenerateBrickWall();
    }

    public void Normal()
    {
        buildBrickWall.wallWidth = 29;
        buildBrickWall.wallHeight = 20;
        buildBrickWall.GenerateBrickWall();
    }
    
    public void Hard()
    {
        buildBrickWall.wallWidth = 59;
        buildBrickWall.wallHeight = 30;
        buildBrickWall.GenerateBrickWall();
    }
    
    public void Nether()
    {
        buildBrickWall.wallWidth = 101;
        buildBrickWall.wallHeight = 50;
        buildBrickWall.GenerateBrickWall();
    }
    
    
}
