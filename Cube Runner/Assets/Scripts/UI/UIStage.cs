using TMPro;
using UnityEngine;

public class UIStage : MonoBehaviour
{
    public string animState;

    [SerializeField]
    private Int32SO currentStage;

    [SerializeField]
    private FlagSO uiStageUpdateEvent;

    private Animator animator;

    private TMP_Text stageText;

    void Start()
    {
        animator = GetComponent<Animator>();
        stageText = GetComponent<TMP_Text>();

        uiStageUpdateEvent.value = false;

        UpdateStageText();
    }

    void LateUpdate()
    {
        if(uiStageUpdateEvent.value)
        {
            UpdateStageText();
            PlayAnimation();

            uiStageUpdateEvent.value = false;
        }
    }

    void UpdateStageText()
    {
        string stage_suffix = currentStage.value switch
        {
            1=>"st",
            2=>"nd",
            3=>"rd",
            _=>"th"
        };

        stageText.text = $"{currentStage.value}{stage_suffix} Stage";
    }

    void PlayAnimation()
    {
        animator.enabled = true;
        animator.Play(animState, -1, 0f);
    }
}
