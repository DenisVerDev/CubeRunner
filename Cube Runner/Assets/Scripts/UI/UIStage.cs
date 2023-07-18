using TMPro;
using UnityEngine;

public class UIStage : MonoBehaviour
{
    [SerializeField]
    private string animState;

    [SerializeField]
    private DynamicInt32SO currentStage;

    [SerializeField]
    private DynamicFlagSO uiStageUpdateEvent;

    private Animator animator;

    private TMP_Text stageText;

    void Start()
    {
        animator = GetComponent<Animator>();
        stageText = GetComponent<TMP_Text>();

        UpdateStageText();
    }

    void LateUpdate()
    {
        if(uiStageUpdateEvent.Value)
        {
            UpdateStageText();
            PlayAnimation();

            uiStageUpdateEvent.Value = false;
        }
    }

    void UpdateStageText()
    {
        string stage_suffix = currentStage.Value switch
        {
            1=>"st",
            2=>"nd",
            3=>"rd",
            _=>"th"
        };

        stageText.text = $"{currentStage.Value}{stage_suffix} Stage";
    }

    void PlayAnimation()
    {
        animator.enabled = true;
        animator.Play(animState, -1, 0f);
    }
}
