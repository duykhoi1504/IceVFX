



// using UnityEngine;
// using DG.Tweening;
// public class ShakeIce : MonoBehaviour
// {

//     [SerializeField] private bool isFreeze = false;
//     [SerializeField] private float duration = .5f;



//     private ParticleSystem pc;
//     private Renderer red;
//     private MaterialPropertyBlock materialPropertyBlock;

//     private void Start()
//     {
//         pc = GetComponent<ParticleSystem>();
//         red = GetComponent<Renderer>();
//         materialPropertyBlock = new MaterialPropertyBlock();



//     }
//     private void Update()
//     {

//         ShakeAnim();


//     }

//     // Update is called once per frame
//     public void ShakeAnim()
//     {

//         int _ShakeUvX = Shader.PropertyToID("_ShakeUvX");
//         int _ShakeUvY = Shader.PropertyToID("_ShakeUvY");
//         int _ShakeUvSpeed = Shader.PropertyToID("_ShakeUvSpeed");
//         if (pc.isPlaying)
//         {
//             DOTween.Kill(this);


//             // setarive OutLine , Negative, Shine truoc khi su dung



//             GetFloatProperty(_ShakeUvX);
//             SetFloatProperty(_ShakeUvX, 0);

//             GetFloatProperty(_ShakeUvY);
//             SetFloatProperty(_ShakeUvY, 0);

//             GetFloatProperty(_ShakeUvSpeed);
//             SetFloatProperty(_ShakeUvSpeed, 0);




//             DOVirtual.DelayedCall(duration, () =>
//             {
//                 GetFloatProperty(_ShakeUvX);
//                 SetFloatProperty(_ShakeUvX, .2f);
//                 GetFloatProperty(_ShakeUvY);
//                 SetFloatProperty(_ShakeUvY, .2f);
//                 DOTween.To(() => GetFloatProperty(_ShakeUvSpeed),
//                                   value => SetFloatProperty(_ShakeUvSpeed, value),
//                                   20f,
//                                   .1f).SetEase(Ease.OutQuint);


//             });

//         }
//         else
//         {

//             GetFloatProperty(_ShakeUvX);
//             SetFloatProperty(_ShakeUvX, 0);

//             GetFloatProperty(_ShakeUvY);
//             SetFloatProperty(_ShakeUvY, 0);

//             GetFloatProperty(_ShakeUvSpeed);
//             SetFloatProperty(_ShakeUvSpeed, 0);
//             DOTween.Kill(this);

//         }
//     }

//     private float GetFloatProperty(int propertyID)
//     {

//         //sao chép các thuộc tính hiện tại từ red vào biến materialPropertyBlock
//         red.GetPropertyBlock(materialPropertyBlock);

//         return materialPropertyBlock.GetFloat(propertyID);
//     }


//     private void SetFloatProperty(int propertyID, float value)
//     {

//         // red.GetPropertyBlock(materialPropertyBlock);

//         materialPropertyBlock.SetFloat(propertyID, value);

//         // áp dụng các thay đổi đã thực hiện trong materialPropertyBlock lại vào red
//         red.SetPropertyBlock(materialPropertyBlock);
//     }

// }
