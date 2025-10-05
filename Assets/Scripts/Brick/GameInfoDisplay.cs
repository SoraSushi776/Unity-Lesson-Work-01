using UnityEngine;
using UnityEngine.UI;

public class GameInfoDisplay : MonoBehaviour
{
    void Update()
    {
        Text _text = GetComponent<Text>();
        BuildABrickWall buildBrickWall = FindObjectOfType<BuildABrickWall>();
        
        _text.text = "已生成的砖块数量: " + buildBrickWall.wallWidth * buildBrickWall.wallHeight;
        _text.text += "\n" + "已消灭的砖块数量: " + Player.RemovedCubeCount;
        _text.text += "\n" + "已发射的球数量: " + Player.BallCount;
        _text.text += "\n" + "分数: " + (Player.RemovedCubeCount * 10 - Player.BallCount);
        
        _text.text += "\n\n" + "游戏状态: " + (Mathf.Approximately(Player.RemovedCubeCount, buildBrickWall.wallWidth * buildBrickWall.wallHeight) ? "已完成" : "进行中");
        _text.text += "\n" + "操作说明: " + "WASD移动, QE上下移动, Space发射, R重新开始";
    }
}
