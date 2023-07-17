using TMPro;
using UnityEngine;

public class UIStage : MonoBehaviour
{
    public string animState;

    [SerializeField]
    private Int32SO currentStage;

    [SerializeField]
    private FlagSO stageChangeAnimation;

    private Animator animator;

    private TMP_Text stageText;

    void Start()
    {
        animator = GetComponent<Animator>();
        stageText = GetComponent<TMP_Text>();
    }

    void LateUpdate()
    {
        UpdateStageText();

        if(stageChangeAnimation.value)
            PlayAnimation();
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

        stageChangeAnimation.value = false;
    }
}
