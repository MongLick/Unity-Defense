using UnityEngine;

public class BuildUI : InGameUI
{
    private TowerPlace towerPlace;
    protected override void Awake()
    {
        base.Awake();
        buttons["ArchorButton"].onClick.AddListener(() => BuildTower("Archor"));
        buttons["CannonButton"].onClick.AddListener(BuildCannonTower);
        buttons["MageButton"].onClick.AddListener(BuildMageTower);
        buttons["BarrackButton"].onClick.AddListener(BuildBarrackTower);

    }


    public void BuildCannonTower()
    {
        towerPlace.BuildTower("Cannon");
        CloseUI();
    }
    public void BuildMageTower()
    {
        towerPlace.BuildTower("Mage");
        CloseUI();

    }
    public void BuildBarrackTower()
    {
        towerPlace.BuildTower("Barracks");
        CloseUI();
    }

    public void BuildTower(string name)
    {
        towerPlace.BuildTower(name);
        CloseUI();
    }
    public void SetTowerPlace(TowerPlace towerPlace)
    {
        this.towerPlace = towerPlace;
    }

}