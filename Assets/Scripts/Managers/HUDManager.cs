using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour
{



    public CanvasGroup[] fades;
    public GameObject countText;
    public Slider slider;
    public PlayerConstants playerConstants;
    public GameObject performancePointText;
    public GameObject taskList;
    public GameObject gameOverScreen;
    public bool isShown = false;
    public Animator taskAnimator;

    public GameObject[] shopCounts;
    public GameObject performancePointsShop;
    public GameObject shopUI;
    public Slider cooldownSlider;
    public Slider cooldownBlockSlider;
    public Image evadeIcon;
    public GameObject upgradeOutline;
    public GameObject unUpgradedGroup;
    public GameObject upgradedGroup;

    public GameObject performancePointsHUD;
    public GameObject addPPprefab;
    public GameObject addTaskPrefab;


    void Start()
    {
        GameManager.instance.updateInventory.AddListener(UpdateInventory);
        GameManager.instance.useConsumable.AddListener(UseConsumable);
        GameManager.instance.consumableEfffect.AddListener(UpdateCooldownBlock);

        GameManager.instance.increaseStress.AddListener(StressBarSlider);
        GameManager.instance.showPerformancePoint.AddListener(PerformancePoint);
        GameManager.instance.animatePerformancePoint.AddListener(AnimatePerformancePoint);
        GameManager.instance.animateTaskAdd.AddListener(AnimateTaskAdd);
        GameManager.instance.playerEvade.AddListener(OnPlayerEvade);
        GameManager.instance.updateEvade.AddListener(UpdateCooldownSprite);

        UpdateShop();
        UpdateInventory();
        UpdateCooldownSprite(GameManager.instance.levelVariables.evadeType);
    }

    // Update HUD inventory after cycle/ purchase
    public void UpdateInventory()
    {
        if (GameManager.instance.runVariables.upgradeBought)
        {
            for (int i = 0; i < 3; i++)
            {
                Image slotImg = upgradedGroup.transform.GetChild(i).GetChild(1).GetComponent<Image>();
                CanvasGroup slotGroup = upgradedGroup.transform.GetChild(i).GetChild(1).GetComponent<CanvasGroup>();
                if (GameManager.instance.activeSlots[i] != -1)
                {
                    slotImg.sprite = GameManager.instance.runVariables.consumableObjects[GameManager.instance.activeSlots[i]].sprite;
                    slotGroup.alpha = 1;
                }
                else
                {
                    slotImg.sprite = null;
                    slotGroup.alpha = 0;
                }
            }
            for (int i = 0; i < 2; i++)
            {
                upgradedGroup.transform.GetChild(i).GetChild(2).GetComponent<TextMeshProUGUI>().text = "" + (
                    GameManager.instance.activeSlots[i] == -1 ?
                        0 :
                        GameManager.instance.runVariables.consumableObjects[GameManager.instance.activeSlots[i]].count
                );
            }

        }
        else
        {
            for (int i = 0; i < 2; i++)
            {
                Image slotImg = unUpgradedGroup.transform.GetChild(i).GetChild(1).GetComponent<Image>();
                CanvasGroup slotGroup = unUpgradedGroup.transform.GetChild(i).GetChild(1).GetComponent<CanvasGroup>();
                if (GameManager.instance.activeSlots[i] != -1)
                {
                    slotImg.sprite = GameManager.instance.runVariables.consumableObjects[GameManager.instance.activeSlots[i]].sprite;
                    slotGroup.alpha = 1;
                }
                else
                {
                    slotImg.sprite = null;
                    slotGroup.alpha = 0;
                }
            }
            unUpgradedGroup.transform.GetChild(0).GetChild(2).GetComponent<TextMeshProUGUI>().text = "" + (
                GameManager.instance.activeSlots[0] == -1 ?
                    0 :
                    GameManager.instance.runVariables.consumableObjects[GameManager.instance.activeSlots[0]].count
            );
        }
    }

    // use consumable fade effect, update shop and inventory
    public void UseConsumable(int slot)
    {

        StartCoroutine(Fade(GameManager.instance.runVariables.upgradeBought ? slot : 0));


        UpdateShop();
        UpdateInventory();
    }

    // Coroutine for use consumable fade effect
    IEnumerator Fade(int slot)
    {
        for (float alpha = 0.5f; alpha >= -0.05f; alpha -= 0.05f)
        {
            fades[slot].alpha = alpha;
            yield return new WaitForSecondsRealtime(0.05f);
        }
    }

    // Control Stress bar
    public void StressBarSlider()
    {
        slider.value = GameManager.instance.levelVariables.stressPoints;
    }

    // Performance points text in Task List (deprecated)
    public void PerformancePoint()
    {
        performancePointText.GetComponent<TextMeshProUGUI>().text = "Performance Point: " + GameManager.instance.levelVariables.levelPP;
        StartCoroutine(UpdateHUDPP());
    }

    // update HUD performance points
    IEnumerator UpdateHUDPP()
    {
        yield return new WaitForSecondsRealtime(1f);
        performancePointsHUD.GetComponent<TextMeshProUGUI>().text = "PP: " + GameManager.instance.levelVariables.levelPP;
    }

    // Add PP animation
    public void AnimatePerformancePoint(int addAmnt)
    {
        GameObject addObj = Instantiate(addPPprefab, performancePointsHUD.transform);
        addObj.transform.SetParent(transform, false);
        addObj.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = (addAmnt > 0 ? "+" : "") + addAmnt;
        performancePointsHUD.GetComponent<Animator>().SetTrigger("Add");
    }

    // add task Animation
    public void AnimateTaskAdd(TaskItem taskItem)
    {
        GameObject addObj = Instantiate(addTaskPrefab, transform);
        addObj.transform.SetParent(transform, false);
        addObj.transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>(taskItem.taskIconPath + "Add");
    }

    // Contol task list
    public void TaskList()
    {
        // taskList.SetActive(true);
        if (isShown)
        {
            Time.timeScale = 1;
            isShown = false;
            taskAnimator.Play("TaskExit");

            GameManager.instance.PlayAudioElement(GameManager.instance.audioElements.hideTaskDetails);
        }
        else
        {
            GameManager.instance.onTaskSuccess.Invoke();
            isShown = true;
            taskAnimator.Play("TasksPage");

            GameManager.instance.PlayAudioElement(GameManager.instance.audioElements.showTaskDetails);
        }
    }

    public void FreezeTime() => Time.timeScale = 0;
    public void DisableTask() => taskList.SetActive(false);
    public void EnableTask() => taskList.SetActive(true);
    public void OnGameOver() => gameOverScreen.SetActive(true);


    // Update HUD with evade type
    public void UpdateEvade(bool isDash)
    {
        GameManager.instance.UpdateEvadeType(isDash ? EvadeType.Dash : EvadeType.Parry);

        // select parry or dash
        GameManager.instance.PlayAudioElement(GameManager.instance.audioElements.menuClick);
    }

    // Buy backpack from shop and notify game manager
    public void BuyUpgrade()
    {
        if (
            !GameManager.instance.runVariables.upgradeBought &&
            GameManager.instance.runVariables.performancePoints >= 500
        )
        {
            GameManager.instance.runVariables.upgradeBought = true;
            GameManager.instance.runVariables.performancePoints -= 500;
            GameManager.instance.activeSlots.Add(0);
            GameManager.instance.CycleInventory();

            // sfx for purchasing backpack upgrade 
            GameManager.instance.PlayAudioElement(GameManager.instance.audioElements.purchaseItem);
        }
        else
        {
            // sfx for not cannot purchase backpack upgrade
            GameManager.instance.PlayAudioElement(GameManager.instance.audioElements.cannotPurchaseItem);
        }
        UpdateShop();


    }

    // Buy a consumable and notify game manager
    public void BuyConsumable(int consumableIndex)
    {
        if (GameManager.instance.runVariables.performancePoints >= GameManager.instance.runVariables.consumableObjects[consumableIndex].cost)
        {
            GameManager.instance.runVariables.consumableObjects[consumableIndex].count += 1;
            GameManager.instance.runVariables.performancePoints -= GameManager.instance.runVariables.consumableObjects[consumableIndex].cost;

            // sfx for purchasing consumable
            GameManager.instance.PlayAudioElement(GameManager.instance.audioElements.purchaseItem);
        }
        else
        {
            // sfx for not cannot purchase consumable
            GameManager.instance.PlayAudioElement(GameManager.instance.audioElements.cannotPurchaseItem);
        }

        GameManager.instance.updateInventory.Invoke();
        UpdateShop();


    }

    // Update shop UI with current values
    public void UpdateShop()
    {
        for (int i = 0; i < GameManager.instance.runVariables.consumableObjects.Length; i++)
        {
            shopCounts[i].GetComponent<TextMeshProUGUI>().text = "In Bag: " + GameManager.instance.runVariables.consumableObjects[i].count;
        }

        performancePointsShop.GetComponent<TextMeshProUGUI>().text = "Owned: " + GameManager.instance.runVariables.performancePoints + " PP";


        upgradeOutline.SetActive(GameManager.instance.runVariables.upgradeBought);

        unUpgradedGroup.SetActive(!GameManager.instance.runVariables.upgradeBought);
        upgradedGroup.SetActive(GameManager.instance.runVariables.upgradeBought);
    }

    // X button to close shop
    public void DisableShop()
    {
        shopUI.SetActive(false);
        GameManager.instance.playerUnFreeze.Invoke();

        // sfx for closing pantry shop
        GameManager.instance.PlayAudioElement(GameManager.instance.audioElements.menuBack);
    }

    // Start cooldown on HUD
    public void OnPlayerEvade(float cooldownTime) => StartCoroutine(CooldownAnimation(cooldownTime));

    // Cooldown coroutine
    IEnumerator CooldownAnimation(float cooldownTime)
    {

        float timePassed = 0f;
        cooldownSlider.value = (1f - (timePassed / cooldownTime)) * GameManager.instance.cooldownPercent;

        yield return new WaitForSecondsRealtime(
            GameManager.instance.levelVariables.evadeType == EvadeType.Dash ?
                GameManager.instance.playerConstants.dashTime :
                GameManager.instance.playerConstants.parryTime
        );

        while (timePassed < cooldownTime)
        {
            cooldownSlider.value = (1f - (timePassed / cooldownTime)) * GameManager.instance.cooldownPercent;
            timePassed += Time.deltaTime;
            yield return null;
        }
        yield return null;
    }

    // If adderall is active, show reduced cooldown
    public void UpdateCooldownBlock(ConsumableType consumableType)
    {
        if (consumableType == ConsumableType.Adderall)
        {
            cooldownBlockSlider.value = 1f - GameManager.instance.cooldownPercent;
        }
    }

    // Update sprite when evade type changes
    public void UpdateCooldownSprite(EvadeType evadeType) => evadeIcon.sprite = (evadeType == EvadeType.Dash) ? GameManager.instance.playerConstants.dashIcon : GameManager.instance.playerConstants.parryIcon;



}
