using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPool : MonoBehaviour
{

    private List<Bullet> _poolObjList;
    private Bullet _poolObj;

    // オブジェクトプールを作成
    public void CreatePool(Bullet obj, int maxCount)
    {
        _poolObj = obj;
        _poolObjList = new List<Bullet>();
        for (int i = 0; i < maxCount; i++)
        {
            var newObj = CreateNewObject();
            newObj.gameObject.SetActive(false);
            _poolObjList.Add(newObj);
        }
    }

    public Bullet GetObject()
    {
        // 使用中でないものを探して返す
        foreach (var obj in _poolObjList)
        {
            if (obj.gameObject.activeSelf == false)
            {
                obj.gameObject.SetActive(true);
                return obj;
            }
        }

        // 全て使用中だったら新しく作って返す
        var newObj = CreateNewObject();
        newObj.gameObject.SetActive(true);
        _poolObjList.Add(newObj);

        return newObj;
    }

    private Bullet CreateNewObject()
    {
        var newObj = Instantiate(_poolObj);
        newObj.name = _poolObj.name + (_poolObjList.Count + 1);

        return newObj;
    }
}