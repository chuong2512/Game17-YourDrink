using DataStructures;
using Solver;
using Sirenix.OdinInspector;
using UnityEngine;

public class LiquidManager : MonoBehaviour
{
    public ZibraLiquid ZibraLiquid;
    public ZibraLiquidMaterialParameters ZibraLiquidMaterial;
    public ZibraLiquidSolverParameters ZibraLiquidSolver;

    private void Start()
    {
        SetPos();
        SetColor();
    }

    private void SetColor()
    {
        ZibraLiquidMaterial.Color = GameDataManager.Instance.drinkSo
            .GetWaterWithID(GameDataManager.Instance.playerData.currentID).color;
    }

    private void FixedUpdate()
    {
       ZibraLiquidSolver.Gravity = new Vector2(Input.acceleration.x*9.5f, Input.acceleration.y*9.5f);
    }

    [Button]
    public void SetPos()
    {
        var x = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)).x * 2 + 1;
        var y = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height, 0)).y * 2 + 1;

        ZibraLiquid.ContainerSize = new Vector3(x, y, 0.2f);
    }
}