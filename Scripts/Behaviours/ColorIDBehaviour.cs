
using UnityEngine;

public class ColorIDBehaviour : IDcontatinerBehavior
{
    public ColorIDDataList colorIDDataListObj;

    private void Awake()
    {
        idObj = colorIDDataListObj.currentColor;
    }
    
}
