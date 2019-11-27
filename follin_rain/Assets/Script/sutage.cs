using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sutage : MonoBehaviour
{
    public TextAsset textAsset;
    //配置するオブジェクト
    public GameObject iwa, hi, matubo, zimen, mizu, tuta, kabe, gake, O_zimen, ananokabe, zimennnonaka,otosiana,tora,saru,eda,katatumuri;
    public Vector3 createPos;
    public Vector3 spaceScale = new Vector3(1.0f, 1.0f, 0f);

    public void Awake()
    {
        CreateStage(createPos);
        createPos = Vector3.zero;
    }
    void CreateStage(Vector3 pos)
    {
        Vector3 originPos = pos;
        string stageTextData = textAsset.text;
        foreach (char c in stageTextData)
        {
            GameObject obj = null;
            if (c == 'i')
            {
                obj = Instantiate(iwa, pos, Quaternion.identity) as GameObject;
                obj.name = iwa.name;
                pos.x += obj.transform.lossyScale.x;
            }
            else if (c == 'h')
            {
                obj = Instantiate(hi, pos, Quaternion.identity) as GameObject;
                obj.name = hi.name;
                pos.x += obj.transform.lossyScale.x;
            }
            else if (c == 'm')
            {
                obj = Instantiate(matubo, pos, Quaternion.identity) as GameObject;
                obj.name = matubo.name;
                pos.x += obj.transform.lossyScale.x;
            }
            else if (c == 'j')
            {
                obj = Instantiate(zimen, pos, Quaternion.identity) as GameObject;
                obj.name = zimen.name;
                pos.x += obj.transform.lossyScale.x;
            }
            else if (c == 'e')
            {
                obj = Instantiate(eda, pos, Quaternion.identity) as GameObject;
                obj.name = eda.name;
                pos.x += obj.transform.lossyScale.x;
            }
            else if (c == 'u')
            {
                obj = Instantiate(tuta, pos, Quaternion.identity) as GameObject;
                obj.name = tuta.name;
                pos.x += obj.transform.lossyScale.x;
            }
            else if (c == 'k')
            {
                obj = Instantiate(kabe, pos, Quaternion.identity) as GameObject;
                obj.name = kabe.name;
                pos.x += obj.transform.lossyScale.x;
            }
            else if (c == 'g')
            {
                obj = Instantiate(gake, pos, Quaternion.identity) as GameObject;
                obj.name = gake.name;
                pos.x += obj.transform.lossyScale.x;
            }
            else if (c == 'o')
            {
                obj = Instantiate(O_zimen, pos, Quaternion.identity) as GameObject;
                obj.name = O_zimen.name;
                pos.x += obj.transform.lossyScale.x;
            }
            else if (c == '>')
            {
                obj = Instantiate(ananokabe, pos, Quaternion.identity) as GameObject;
                obj.name = ananokabe.name;
                pos.x += obj.transform.lossyScale.x;
            }
            else if (c == 'n')
            {
                obj = Instantiate(zimen, pos, Quaternion.identity) as GameObject;
                obj.name = zimen.name;
                pos.x += obj.transform.lossyScale.x;
            }
            else if (c == 'd')
            {
                obj = Instantiate(otosiana, pos, Quaternion.identity) as GameObject;
                obj.name = otosiana.name;
                pos.x += obj.transform.lossyScale.x;
            }
            else if (c == 't')
            {
                obj = Instantiate(tora, pos, Quaternion.identity) as GameObject;
                obj.name = tora.name;
                pos.x += obj.transform.lossyScale.x;
            }
            else if (c == 'S')
            {
                obj = Instantiate(saru, pos, Quaternion.identity) as GameObject;
                obj.name = saru.name;
                pos.x += obj.transform.lossyScale.x;
            }
            else if (c == 'M')
            {
                obj = Instantiate(mizu, pos, Quaternion.identity) as GameObject;
                obj.name = mizu.name;
                pos.x += obj.transform.lossyScale.x;
            }
            else if (c == 'K')
            {
                obj = Instantiate(katatumuri, pos, Quaternion.identity) as GameObject;
                obj.name = katatumuri.name;
                pos.x += obj.transform.lossyScale.x;
            }
            else if (c == '\n')
            {
                pos.y -= spaceScale.y;
                pos.x = originPos.x;
            }
            else if (c == '*')
            {
                pos.x += spaceScale.x;
            }

        }
    }
}
