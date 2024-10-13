



//

using UnityEngine;
using DG.Tweening;
public class FreezeMaterial : MonoBehaviour
{

    [SerializeField] private bool isFreeze = false;
    [SerializeField] private float duration = .5f;

    private void Update()
    {
        if (isFreeze)
        {
            isFreeze = false;
            FreezeAnim();
        }
    }
    private Renderer red;
    private MaterialPropertyBlock materialPropertyBlock;

    void Start()
    {
        red = GetComponent<Renderer>();
        materialPropertyBlock = new MaterialPropertyBlock();
    }

    // Update is called once per frame
    public void FreezeAnim()
    {
        

        // setarive OutLine , Negative, Shine truoc khi su dung
        int shineLocation = Shader.PropertyToID("_ShineLocation");
        int outlineAlpha = Shader.PropertyToID("_OutlineAlpha");
        int negativeAmount = Shader.PropertyToID("_NegativeAmount");

        
        GetFloatProperty(outlineAlpha);
        SetFloatProperty(outlineAlpha, 1f);



        GetFloatProperty(negativeAmount);
        SetFloatProperty(negativeAmount, 1f);

        GetFloatProperty(shineLocation);
        SetFloatProperty(shineLocation, 0f);

        DOTween.To(() => GetFloatProperty(shineLocation),
                      value => SetFloatProperty(shineLocation, value),
                      1f,
                      duration)
                  .SetEase(Ease.Unset);

        DOVirtual.DelayedCall(duration, () =>
   {

       DOTween.To(() => GetFloatProperty(outlineAlpha),
                     value => SetFloatProperty(outlineAlpha, value),
                     0f,
                     .1f)
                 .SetEase(Ease.Unset);
       DOTween.To(() => GetFloatProperty(negativeAmount),
                    value => SetFloatProperty(negativeAmount, value),
                    0f,
                    .1f)
                    .SetEase(Ease.Unset);
   });
    }

    private float GetFloatProperty(int propertyID)
    {

        //sao chép các thuộc tính hiện tại từ red vào biến materialPropertyBlock
        red.GetPropertyBlock(materialPropertyBlock);

        return materialPropertyBlock.GetFloat(propertyID);
    }


    private void SetFloatProperty(int propertyID, float value)
    {

        // red.GetPropertyBlock(materialPropertyBlock);

        materialPropertyBlock.SetFloat(propertyID, value);

        // áp dụng các thay đổi đã thực hiện trong materialPropertyBlock lại vào red
        red.SetPropertyBlock(materialPropertyBlock);
    }

}
